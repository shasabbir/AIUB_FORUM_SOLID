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
    public class PostServices
    {
        public static PostModel Get(int id)

        {
            var pt = DataAccessFactory.PostDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Post, PostModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<PostModel>(pt);
            return stm;
        }
        public static List<PostModel> Get()

        {
            var pt = DataAccessFactory.PostDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Post, PostModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<List<PostModel>>(pt);
            return stm;
        }
        public static bool Delete(int id)

        {
            return DataAccessFactory.PostDataAccess().Delete(id);
            
        }
        public static bool Add(PostModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PostModel, Post>());
            var mapper = new Mapper(config);
            var p = mapper.Map<Post>(ppp);
            return DataAccessFactory.PostDataAccess().Add(p);
        }
        public static bool Edit(PostModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PostModel, Post>());
            var mapper = new Mapper(config);
            var p = mapper.Map<Post>(ppp);
            return DataAccessFactory.PostDataAccess().Edit(p);
        }

    }
}
