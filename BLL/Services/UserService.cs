using DAL;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.Entities;
using DAL.Database;

namespace BLL.Services
{
    public class StudentService
    {
        public static bool AuthenticateStudent(string uname, string pass) { 
            var  rt = DataAccessFactory.AuthAccess().Authenticate(uname, pass);
            return rt;
        }
        public static UserModel Get(int id) {
            var st = DataAccessFactory.UserDataAccess().Get(id);
            var s = new UserModel() { 
               UserId = st.UserId,
               Password = st.Password,
               Username = st.Username,
               Email = st.Email,
               AboutMe = st.AboutMe,
               ApplyCount = st.ApplyCount,
               CreationDate = st.CreationDate,
               CV = st.CV,
               Location = st.Location,
               ProfilePic = st.ProfilePic,
               Reputation = st.Reputation,
               UserType = st.UserType
            };
            return s;
        }
        public static List<UserModel> Get() {
            var sts = DataAccessFactory.UserDataAccess().Get();
            return sts.Select(s => new UserModel()
            {
                UserId = s.UserId,
                Password = s.Password,
                Username = s.Username,
                Email = s.Email,
                AboutMe = s.AboutMe,
                ApplyCount = s.ApplyCount,
                CreationDate = s.CreationDate,
                CV = s.CV,
                Location = s.Location,
                ProfilePic = s.ProfilePic,
                Reputation = s.Reputation,
                UserType = s.UserType
            }).ToList();

        }
        public static List<UserModel> GetAll() {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<UserModel>>(DataAccessFactory.UserDataAccess().Get());
            return data;
        }
    }
}