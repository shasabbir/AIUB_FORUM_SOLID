using AutoMapper;
using BLL.Entities;
using DAL;
using DAL.Database;
using System.Collections.Generic;

namespace BLL.Services
{
    public class UserService
    {

        public static List<UserModel> GetAllUsers()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.UserDataAccess();
            var data = mapper.Map<List<UserModel>>(da.Get());
            return data;
        }

        public static List<UserModel> GetSearchUsers(string search)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.UserDataAccess();
            var data = mapper.Map<List<UserModel>>(da.Search(search));
            return data;
        }

        public static UserModel GetUser(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.UserDataAccess();
            var data = mapper.Map<UserModel>(da.Get(id));
            return data;
        }

        public static bool AddUser(UserModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(u);
            return DataAccessFactory.UserDataAccess().Add(data);
        }

        public static bool EditUser(UserModel u)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(u);
            return DataAccessFactory.UserDataAccess().Edit(data);
        }

        public static bool DeleteUser(int id)
        {
            return DataAccessFactory.UserDataAccess().Delete(id);
        }
    }
}