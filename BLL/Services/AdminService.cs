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
    public class AdminServices
    {
        public static AdminModel Get(int id)

        {
            var pt = DataAccessFactory.AdminDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<AdminModel>(pt);
            return stm;
        }
        public static List<AdminModel> Get()

        {
            var pt = DataAccessFactory.AdminDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<List<AdminModel>>(pt);
            return stm;
        }
        public static bool Delete(int id)

        {
            return DataAccessFactory.AdminDataAccess().Delete(id);

        }
        public static bool Add(AdminModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Admin>());
            var mapper = new Mapper(config);
            var p = mapper.Map<Admin>(ppp);
            return DataAccessFactory.AdminDataAccess().Add(p);
        }
        public static bool Edit(AdminModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Admin>());
            var mapper = new Mapper(config);
            var p = mapper.Map<Admin>(ppp);
            return DataAccessFactory.AdminDataAccess().Edit(p);
        }

    }
}
