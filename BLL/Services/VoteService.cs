using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;
using System.Collections.Generic;

namespace BLL.Services
{
    public class VoteService
    {
        public static List<VoteModel> GetAllVotes()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Vote, VoteModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.VoteDataAccess();
            var data = mapper.Map<List<VoteModel>>(da.Get());
            return data;
        }


        public static VoteModel GetVote(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Vote, VoteModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.VoteDataAccess();
            var data = mapper.Map<VoteModel>(da.Get(id));
            return data;
        }

        public static void AddVote(VoteModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<VoteModel, Vote>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Vote>(u);
            DataAccessFactory.VoteDataAccess().Add(data);
        }

        public static void EditVote(VoteModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<VoteModel, Vote>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Vote>(u);
            DataAccessFactory.VoteDataAccess().Edit(data);

        }

        public static void DeleteVote(int id)
        {
            DataAccessFactory.VoteDataAccess().Delete(id);
        }
    }
}
