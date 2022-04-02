using System.Collections.Generic;
using DAL.Database;

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
            throw new System.NotImplementedException();
        }

        public Job Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Job> Get()
        {
            throw new System.NotImplementedException();
        }

        public bool Edit(Job obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}