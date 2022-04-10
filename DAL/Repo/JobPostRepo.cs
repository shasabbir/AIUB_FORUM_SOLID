using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class JobPostRepo : IRepository<JobPost, int>
    {
        private AIUB_ForumEntities db;


        public JobPostRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }
        public bool Add(JobPost obj)
        {
            db.JobPosts.Add(obj);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = db.JobPosts.FirstOrDefault(e => e.JPId == id);
            if (c == null)
            {
                return false;
            }

            db.JobPosts.Remove(c);
            return db.SaveChanges() != 0; ;
        }

        public bool Edit(JobPost obj)
        {

            var p = db.JobPosts.FirstOrDefault(en => en.JPId == obj.JPId);
            db.Entry(p).CurrentValues.SetValues(obj);
            return db.SaveChanges() != 0;
        }

        public JobPost Get(int id)
        {
            return db.JobPosts.FirstOrDefault(x => x.JPId == id);
        }

        public List<JobPost> Get()
        {
            return db.JobPosts.ToList();
        }
    }
}
