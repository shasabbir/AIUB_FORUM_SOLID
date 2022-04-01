using DAL;
using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;

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
            return sts.Select(s => new UserModel() {UserId = s.UserId,Username = s.Username,Email = s.Email, Password = s.Password}).ToList();

        }
    }
}