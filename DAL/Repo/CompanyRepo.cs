using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class CompanyRepo : IRepository<Company, int>
    {
        private AIUB_ForumEntities db;

        public CompanyRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }

        public bool Add(Company obj)
        {
            db.Companies.Add(obj);
            return db.SaveChanges() != 0;
        }

        public Company Get(int id)
        {
            return db.Companies.FirstOrDefault(x => x.CompanyId == id);
        }

        public List<Company> Get()
        {
            return db.Companies.ToList();
        }

        public bool Edit(Company obj)
        {
            var p = db.Companies.FirstOrDefault(en => en.CompanyId == obj.CompanyId);
            db.Entry(p).CurrentValues.SetValues(obj);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = db.Companies.FirstOrDefault(e => e.CompanyId == id);
            if (c == null)
            {
                return false;
            }

            db.Companies.Remove(c);
            return db.SaveChanges() != 0; ;
        }
    }
}