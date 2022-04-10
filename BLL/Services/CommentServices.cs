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
    public class CommentServices
    {
        public static CommentModel Get(int id)

        {
            var pt = DataAccessFactory.CommentDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, CommentModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<CommentModel>(pt);
            return stm;
        }
        public static List<CommentModel> Get()

        {
            var pt = DataAccessFactory.CommentDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Comment, CommentModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<List<CommentModel>>(pt);
            return stm;
        }
        public static bool Delete(int id)

        {
            return DataAccessFactory.CommentDataAccess().Delete(id);

        }
        public static bool Add(CommentModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CommentModel, Comment>());
            var mapper = new Mapper(config);
            var p = mapper.Map<Comment>(ppp);
            return DataAccessFactory.CommentDataAccess().Add(p);
        }
        public static bool Edit(CommentModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CommentModel, Comment>());
            var mapper = new Mapper(config);
            var p = mapper.Map<Comment>(ppp);
            return DataAccessFactory.CommentDataAccess().Edit(p);
        }
    }
}
