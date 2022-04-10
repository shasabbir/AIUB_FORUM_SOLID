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
    public class AnswerServices
    {
        public static AnswerModel Get(int id)

        {
            var pt = DataAccessFactory.AnswerDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Answer, AnswerModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<AnswerModel>(pt);
            return stm;
        }
        public static List<AnswerModel> Get()

        {
            var pt = DataAccessFactory.AnswerDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Answer, AnswerModel>());
            var mapper = new Mapper(config);
            var stm = mapper.Map<List<AnswerModel>>(pt);
            return stm;
        }
        public static bool Delete(int id)

        {
            return DataAccessFactory.AnswerDataAccess().Delete(id);

        }
        public static bool Add(AnswerModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AnswerModel, Answer>());
            var mapper = new Mapper(config);
            var p = mapper.Map<Answer>(ppp);
            return DataAccessFactory.AnswerDataAccess().Add(p);
        }
        public static bool Edit(AnswerModel ppp)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AnswerModel, Answer>());
            var mapper = new Mapper(config);
            var p = mapper.Map<Answer>(ppp);
            return DataAccessFactory.AnswerDataAccess().Edit(p);
        }
    }
}
