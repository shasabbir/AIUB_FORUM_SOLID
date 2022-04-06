using DAL.Database;
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
            var p = db.Users.FirstOrDefault(en => en.UserId == obj.UserId);
            db.Entry(p).CurrentValues.SetValues(obj.UserId);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = db.Users.FirstOrDefault(e => e.UserId == id);
            if (c == null) return false;
            db.Users.Remove(c);
            return true;
        }

        public bool Authenticate(string email, string pass)
        {
            var data = (from e in db.Users
                where e.Password.Equals(pass) &&
                      e.Email.Equals(email)
                select e).FirstOrDefault();
            return data != null;
        }
    }
}