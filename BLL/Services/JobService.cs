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
    public class JobService
    {
        public static JobModel Get(int id)

        {
            var st = DataAccessFactory.JobDataAccess().Get(id);
            var s = new JobModel()
            {
                JobId = st.JobId,   
                CompanyId = st.CompanyId,
                JobType = st.JobType,   
                PositonName = st.PositonName,
                Description = st.Description,
                Salary = st.Salary,
               
            };
            return s;
        }

        public static List<JobModel> GetByCompanyId(int ID)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Job, JobModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<JobModel>>(DataAccessFactory.JobDataAccess().Get().Where(n => n.CompanyId == ID).Select(n => n).ToList());
            return data;
        }

        public static List<JobModel> GetByPositionName(string postion)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Job,JobModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<JobModel>>(DataAccessFactory.JobDataAccess().Get().Where(n => n.PositonName == postion).Select(n => n).ToList());
            return data;
        }

        public static List<JobModel> Get()
        {
            var sts = DataAccessFactory.JobDataAccess().Get();
            return sts.Select(s => new JobModel()
            {
                JobId = s.JobId,    
                CompanyId = s.CompanyId,
               JobType= s.JobType,  
               PositonName= s.PositonName,  
               Description= s.Description,
               Salary= s.Salary,
            }).ToList();
        }

     
        public static void Add(JobModel j)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<JobModel,Job>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Job>(j);
            DataAccessFactory.JobDataAccess().Add(data);
        }
        public static void Edit(JobModel j)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap< JobModel, Job>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Job>(j);
            DataAccessFactory.JobDataAccess().Edit(data);

        }

        public static void Delete(int id)
        {
            DataAccessFactory.JobDataAccess().Delete(id);
        }
    }
}
