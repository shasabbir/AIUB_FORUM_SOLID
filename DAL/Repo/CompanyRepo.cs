using System.Collections.Generic;
using DAL.Database;

namespace DAL.Repo
{
    public class CompanyRepo : IRepositoryN<Company, int>
    {
        private AIUB_ForumEntities db;

        public CompanyRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }

        public bool Add(Company obj)
        {
            throw new System.NotImplementedException();
        }

        public Company Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Company> Get()
        {
            throw new System.NotImplementedException();
        }

        public bool Edit(Company obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}