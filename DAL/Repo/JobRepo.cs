using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class JobRepo : IRepository<Job, int>
    {
        private AIUB_ForumEntities _db;

        public JobRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }

        public bool Add(Job obj)
        {
            _db.Jobs.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public Job Get(int id)
        {
            return _db.Jobs.FirstOrDefault(x => x.JobId == id);
        }

        public List<Job> Get()
        {
            return _db.Jobs.ToList();
        }

        public bool Edit(Job obj)
        {
            var p = _db.Jobs.FirstOrDefault(en => en.JobId == obj.JobId);
            _db.Entry(p).CurrentValues.SetValues(obj.JobId);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = _db.Jobs.FirstOrDefault(e => e.JobId == id);
            if (c == null)
            {
                return false;
            }

            _db.Jobs.Remove(c);
            return true;
        }
    }
}