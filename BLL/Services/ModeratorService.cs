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
    public class ModeratorServices
    {
        public static ModeratorModel Get(int id)

        {
            var pt = DataAccessFactory.ModeratorDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Moderator, ModeratorModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<ModeratorModel>(pt);
            return stm;
        }
        public static List<ModeratorModel> Get()

        {
            var pt = DataAccessFactory.ModeratorDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Moderator, ModeratorModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<List<ModeratorModel>>(pt);
            return stm;
        }
        public static bool Delete(int id)

        {
            return DataAccessFactory.ModeratorDataAccess().Delete(id);

        }
        public static bool Add(ModeratorModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModeratorModel, Moderator>());
            var mapper = new Mapper(config);
            var p = mapper.Map<Moderator>(ppp);
            return DataAccessFactory.ModeratorDataAccess().Add(p);
        }
        public static bool Edit(ModeratorModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ModeratorModel, Moderator>());
            var mapper = new Mapper(config);
            var p = mapper.Map<Moderator>(ppp);
            return DataAccessFactory.ModeratorDataAccess().Edit(p);
        }

    }
}
