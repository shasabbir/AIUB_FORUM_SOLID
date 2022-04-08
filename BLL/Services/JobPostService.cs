using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class JobPostService
    {
        public static JobPostModel Get(int id)

        {
            var st = DataAccessFactory.JobPostDataAccess().Get(id);
            var s = new JobPostModel()
            {
                JpId = st.JPId,
                JpCreationDate = st.JPCreationDate,
                JpDeleteDate = st.JPDeleteDate,
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
                JpId = s.JPId,
                JpCreationDate = s.JPCreationDate,
                JpDeleteDate = s.JPDeleteDate,
                Body = s.Body,
                JobId = s.JobId,
                Title = s.Title,

            }).ToList();
        }
        public static List<JobPostModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<JobPost, JobPostModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<JobPostModel>>(DataAccessFactory.CompanyDataAccess().Get());
            return data;
        }
    }
}
