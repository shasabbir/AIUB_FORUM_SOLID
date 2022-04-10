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
    public class AnswerCommentServices
    {
        public static AnswerCommentModel Get(int id)

        {
            var pt = DataAccessFactory.AnswerCommentDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AnswerComment, AnswerCommentModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<AnswerCommentModel>(pt);
            return stm;
        }
        public static List<AnswerCommentModel> Get()

        {
            var pt = DataAccessFactory.AnswerCommentDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AnswerComment, AnswerCommentModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<List<AnswerCommentModel>>(pt);
            return stm;
        }
        public static bool Delete(int id)

        {
            return DataAccessFactory.AnswerCommentDataAccess().Delete(id);

        }
        public static bool Add(AnswerCommentModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AnswerCommentModel, AnswerComment>());
            var mapper = new Mapper(config);
            var p = mapper.Map<AnswerComment>(ppp);
            return DataAccessFactory.AnswerCommentDataAccess().Add(p);
        }
        public static bool Edit(AnswerCommentModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AnswerCommentModel, AnswerComment>());
            var mapper = new Mapper(config);
            var p = mapper.Map<AnswerComment>(ppp);
            return DataAccessFactory.AnswerCommentDataAccess().Edit(p);
        }
    }
}
