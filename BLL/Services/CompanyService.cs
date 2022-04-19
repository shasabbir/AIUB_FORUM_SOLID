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
    public class CompanyService
    {
        public static CompanyModel Get(int id)
       
        {
            var st = DataAccessFactory.CompanyDataAccess().Get(id);
            var s = new CompanyModel()
            {
                CompanyId = st.CompanyId,
                UserId = st.UserId,
               JobPostCount = st.JobPostCount,
               CompanyName = st.CompanyName,
               Location = st.Location,
               CDescription = st.CDescription,
               CCategory = st.CCategory,
               Email = st.Email
            };
            return s;
        }
        public static List<CompanyModel> GetByCompanyName(string Company)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Company, CompanyModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CompanyModel>>(DataAccessFactory.CompanyDataAccess().Get().Where(n => n.CompanyName == Company).Select(n => n).ToList());
            return data;
        }
        public static List<CompanyModel> Get()
        {
            var sts = DataAccessFactory.CompanyDataAccess().Get();
            return sts.Select(s => new CompanyModel()
            {
                CompanyId = s.CompanyId,
                UserId = s.UserId,
                JobPostCount = s.JobPostCount,
                CompanyName = s.CompanyName,
                Location = s.Location,
                CDescription = s.CDescription,
                CCategory = s.CCategory,
                Email = s.Email
            }).ToList();
        }
        
        public static void Add(CompanyModel c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CompanyModel,Company > ();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Company>(c);
            DataAccessFactory.CompanyDataAccess().Add(data);
        }
        public static void Edit(CompanyModel c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap< CompanyModel,Company > ();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Company>(c);
            DataAccessFactory.CompanyDataAccess().Edit(data);

        }

        public static void Delete(int id)
        {
            DataAccessFactory.CompanyDataAccess().Delete(id);
        }
    }
}
