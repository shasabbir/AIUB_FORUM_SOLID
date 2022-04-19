using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AdminRepo : IRepository<Admin, int>
    {
        private AIUB_ForumEntities db;
        public AdminRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }
        public bool Add(Admin obj)
        {
            db.Admins.Add(obj);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var oobj = db.Admins.FirstOrDefault(x => x.AdminId == id);
            if (oobj == null) { return false; }

            db.Admins.Remove(oobj);
            if (db.SaveChanges() == 1) { return true; }
            return false;

        }

        public bool Edit(Admin obj)
        {
            var oobj = db.Admins.FirstOrDefault(x => x.AdminId == obj.AdminId);
            db.Entry(oobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() != 0;
        }

        public Admin Get(int id)
        {
            return db.Admins.FirstOrDefault(x => x.AdminId == id);
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }
    }
}
