using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class UserRepo : IRepository<User, int, string>
    {
        private readonly AIUB_ForumEntities _db;


        public UserRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }

        public bool Add(User obj)
        {
            _db.Users.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public bool Edit(User obj)
        {
            var p = _db.Users.FirstOrDefault(en => en.UserId == obj.UserId);
            _db.Entry(p).CurrentValues.SetValues(obj);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = _db.Users.FirstOrDefault(e => e.UserId == id);
            if (c == null)
            {
                return false;
            }
            _db.Users.Remove(c);
            return true;
        }


        public List<User> Get()
        {
            return _db.Users.ToList();
        }

        public List<User> Search(string search)
        {
            var list = (from p in _db.Users
                        where p.Username.Contains(search)
                        select p).ToList();
            return list;
        }

        public User Get(int id)
        {
            return _db.Users.FirstOrDefault(e => e.UserId == id);
        }
    }
}
