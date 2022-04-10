using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class JobRepo : IRepository<Job, int>
    {
        private AIUB_ForumEntities db;

        public JobRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }

        public bool Add(Job obj)
        {
            db.Jobs.Add(obj);
            return db.SaveChanges() != 0;
        }

        public Job Get(int id)
        {
            return db.Jobs.FirstOrDefault(x => x.JobId == id);
        }

        public List<Job> Get()
        {
            return db.Jobs.ToList();
        }

        public bool Edit(Job obj)
        {

            var p = db.Jobs.FirstOrDefault(en => en.JobId == obj.JobId);
            db.Entry(p).CurrentValues.SetValues(obj);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = db.Jobs.FirstOrDefault(e => e.JobId == id);
            if (c == null)
            {
                return false;
            }

            db.Jobs.Remove(c);
            return db.SaveChanges() != 0; ;
        }
    }
}