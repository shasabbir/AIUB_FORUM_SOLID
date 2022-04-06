using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;

namespace BLL.Services
{
    public class BadgeServices
    {
        public static BadgeModel Get(int id) {
            var st = DataAccessFactory.BadgeDataAccess().Get(id);
            var s = new BadgeModel() {
                BadgeId = st.BadgeId,
                UserId = st.UserId,
                Name = st.Name,
                Date = st.Date,
                Class = st.Class
            };
            return s;
        }
        public static List<BadgeModel> Get() {
            var sts = DataAccessFactory.BadgeDataAccess().Get();
            return sts.Select(s => new BadgeModel()
            {
                BadgeId = s.BadgeId,
                UserId = s.UserId,
                Name = s.Name,
                Date = s.Date,
                Class = s.Class
            }).ToList();
        }
        public static List<BadgeModel> GetAll() {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Badge, BadgeModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BadgeModel>>(DataAccessFactory.BadgeDataAccess().Get());
            return data;
        }
    }
}
