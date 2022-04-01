using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static AIUB_ForumEntities db = new AIUB_ForumEntities();
        public static IRepository<User,int> UserDataAccess() {
            return new UserRepo(db);
        }
       
        public static IAuth AuthAccess() {
            return new UserRepo(db);
        }
    }
}