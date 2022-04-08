using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class PostRepo : IRepository<Post, int>
    {
        private AIUB_ForumEntities _db;

        public PostRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }

        public bool Add(Post obj)
        {
            _db.Posts.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public Post Get(int id)
        {
            return _db.Posts.FirstOrDefault(x => x.PostId == id); ;
        }

        public List<Post> Get()
        {
            return _db.Posts.ToList();
        }

        public bool Edit(Post obj)
        {
            var p = _db.Posts.FirstOrDefault(en => en.PostId == obj.PostId);
            _db.Entry(p).CurrentValues.SetValues(obj.PostId);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = _db.Posts.FirstOrDefault(e => e.PostId == id);
            if (c == null)
            {
                return false;
            }

            _db.Posts.Remove(c);
            return true;
        }
    }
}
