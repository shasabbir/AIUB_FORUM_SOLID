using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class CompanyRepo : IRepository<Company, int>
    {
        private AIUB_ForumEntities _db;

        public CompanyRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }

        public bool Add(Company obj)
        {
            _db.Companies.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public Company Get(int id)
        {
            return _db.Companies.FirstOrDefault(x => x.UserId == id);
        }

        public List<Company> Get()
        {
            return _db.Companies.ToList();
        }

        public bool Edit(Company obj)
        {
            var p = _db.Companies.FirstOrDefault(en => en.CompanyId == obj.CompanyId);
            _db.Entry(p).CurrentValues.SetValues(obj.CompanyId);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = _db.Companies.FirstOrDefault(e => e.CompanyId == id);
            if (c == null)
            {
                return false;
            }

            _db.Companies.Remove(c);
            return true;
        }
    }
}