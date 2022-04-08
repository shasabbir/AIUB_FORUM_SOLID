using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class JobPostRepo : IRepository<JobPost, int>
    {
        private AIUB_ForumEntities _db;


        public JobPostRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }
        public bool Add(JobPost obj)
        {
            _db.JobPosts.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = _db.JobPosts.FirstOrDefault(e => e.JPId == id);
            if (c == null)
            {
                return false;
            }

            _db.JobPosts.Remove(c);
            return true;
        }

        public bool Edit(JobPost obj)
        {
            var p = _db.JobPosts.FirstOrDefault(en => en.JPId == obj.JPId);
            _db.Entry(p).CurrentValues.SetValues(obj.JPId);
            return _db.SaveChanges() != 0;
        }

        public JobPost Get(int id)
        {
            return _db.JobPosts.FirstOrDefault(x => x.JPId == id);
        }

        public List<JobPost> Get()
        {
            return _db.JobPosts.ToList();
        }
    }
}
