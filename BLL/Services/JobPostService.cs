using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class JobPostService
    {
        public static JobPostModel Get(int id)

        {
            var st = DataAccessFactory.JobPostDataAccess().Get(id);
            var s = new JobPostModel()
            {
                JPId = st.JPId,
                JPCreationDate = st.JPCreationDate,
                JPDeleteDate = st.JPDeleteDate,
                Body = st.Body,
                JobId = st.JobId,
                Title = st.Title,
            };
            return s;
        }
        public static List<JobPostModel> Get()
        {
            var sts = DataAccessFactory.JobPostDataAccess().Get();
            return sts.Select(s => new JobPostModel()
            {
                JPId = s.JPId,
                JPCreationDate = s.JPCreationDate,
                JPDeleteDate = s.JPDeleteDate,
                Body = s.Body,
                JobId = s.JobId,
                Title = s.Title,

            }).ToList();
        }
        public static List<JobPostModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<JobPost, JobPostModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<JobPostModel>>(DataAccessFactory.JobPostDataAccess().Get());
            return data;
        }

        public static List<JobPostModel> GetByTitle(string Title)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<JobPost, JobPostModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<JobPostModel>>(DataAccessFactory.JobPostDataAccess().Get().Where(n => n.Title == Title).Select(n => n).ToList());
            return data;
        }


        public static List<JobPostModel> GetByCreateDate(DateTime date)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<JobPost, JobPostModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<JobPostModel>>(DataAccessFactory.JobPostDataAccess().Get().Where(n => n.JPCreationDate == date).Select(n => n).ToList());
            return data;
        }

        public static void Add(JobPostModel j)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<JobPostModel, JobPost>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<JobPost>(j);
            DataAccessFactory.JobPostDataAccess().Add(data);
        }
        public static void Edit(JobPostModel j)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<JobPostModel, JobPost>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<JobPost>(j);
            DataAccessFactory.JobPostDataAccess().Edit(data);

        }

        public static void Delete(int id)
        {
            DataAccessFactory.JobPostDataAccess().Delete(id);
        }
    }
}
