using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class VoteService
    {
        public static VoteModel Get(int id)
        {
            var st = DataAccessFactory.VoteDataAccess().Get(id);
            var s = new VoteModel()
            {
                VoteId = st.VoteId,
                UserId = st.UserId,
                Date = st.Date,
                PostId = st.PostId,
                Value = st.Value
            };
            return s;
        }
        public static List<VoteModel> Get()
        {
            var sts = DataAccessFactory.VoteDataAccess().Get();
            return sts.Select(s => new VoteModel()
            {
                VoteId = s.VoteId,
                UserId = s.UserId,
                Date = s.Date,
                PostId = s.PostId,
                Value = s.Value

            }).ToList();
        }
        public static List<VoteModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vote, VoteModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<VoteModel>>(DataAccessFactory.VoteDataAccess().Get());
            return data;
        }
    }
}
