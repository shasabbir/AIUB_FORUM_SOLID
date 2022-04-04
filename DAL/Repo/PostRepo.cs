using System.Collections.Generic;
using System.Linq;
using DAL.Database;

namespace DAL.Repo
{
    public class PostRepo : IRepositoryN<Post, int>
    {
         private AIUB_ForumEntities db;

        public PostRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }

        public bool Add(Post obj)
        {
            db.Posts.Add(obj);
            return db.SaveChanges() != 0;
        }

        public Post Get(int id)
        {
            return db.Posts.FirstOrDefault(x => x.PostId == id);;
        }

        public List<Post> Get()
        {
            return db.Posts.ToList();
        }

        public bool Edit(Post obj)
        {
            var p = db.Posts.FirstOrDefault(en => en.PostId == obj.PostId);
            db.Entry(p).CurrentValues.SetValues(obj.PostId);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = db.Posts.FirstOrDefault(e => e.PostId == id);
            if (c == null) return false;
            db.Posts.Remove(c);
            return true;
        }
    }
}
