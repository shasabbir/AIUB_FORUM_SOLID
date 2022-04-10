using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class PostRepo : IRepository<Post,int>
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

        public bool Delete(int id)
        {
            var oobj = db.Posts.FirstOrDefault(x => x.PostId == id);
            if (oobj == null) { return false; }
            
            db.Posts.Remove(oobj);
            if (db.SaveChanges() == 1) { return true; }
            return false;
            
        }

        public bool Edit(Post obj)
        {
            var oobj = db.Posts.FirstOrDefault(x => x.PostId == obj.PostId);
            db.Entry(oobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() != 0;
        }

        public Post Get(int id)
        {
            return db.Posts.FirstOrDefault(x => x.PostId == id);
        }

        public List<Post> Get()
        {
            return db.Posts.ToList();
        }
    }
}
