using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class UserRepo : IRepository<User, int>,IAuth
    {
        private AIUB_ForumEntities db;
      

        public UserRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }

        public bool Add(User obj)
        {
            db.Users.Add(obj);
            return db.SaveChanges() != 0;
        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(x => x.UserId == id);
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public bool Edit(User obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Authenticate(string uname, string pass)
        {
            return true;
        }
    }
}