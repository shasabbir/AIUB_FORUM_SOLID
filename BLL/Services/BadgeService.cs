using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;
using System.Collections.Generic;

namespace BLL.Services
{
    public class BadgeService
    {
        public static List<BadgeModel> GetAllBadges()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Badge, BadgeModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.BadgeDataAccess();
            var data = mapper.Map<List<BadgeModel>>(da.Get());
            return data;
        }


        public static BadgeModel GetBadge(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Badge, BadgeModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.BadgeDataAccess();
            var data = mapper.Map<BadgeModel>(da.Get(id));
            return data;
        }

        public static bool AddBadge(BadgeModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BadgeModel, Badge>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Badge>(u);
            return DataAccessFactory.BadgeDataAccess().Add(data);
        }

        public static bool EditBadge(BadgeModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BadgeModel, Badge>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Badge>(u);
            return DataAccessFactory.BadgeDataAccess().Edit(data);

        }

        public static bool DeleteBadge(int id)
        {
            return DataAccessFactory.BadgeDataAccess().Delete(id);
        }
    }
}
