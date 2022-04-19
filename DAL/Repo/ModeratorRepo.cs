using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class ModeratorRepo : IRepository<Moderator, int>
    {
        private AIUB_ForumEntities db;
        public ModeratorRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }
        public bool Add(Moderator obj)
        {
            db.Moderators.Add(obj);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var oobj = db.Moderators.FirstOrDefault(x => x.ModeratorId == id);
            if (oobj == null) { return false; }

            db.Moderators.Remove(oobj);
            if (db.SaveChanges() == 1) { return true; }
            return false;

        }

        public bool Edit(Moderator obj)
        {
            var oobj = db.Moderators.FirstOrDefault(x => x.ModeratorId == obj.ModeratorId);
            db.Entry(oobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() != 0;
        }

        public Moderator Get(int id)
        {
            return db.Moderators.FirstOrDefault(x => x.ModeratorId == id);
        }

        public List<Moderator> Get()
        {
            return db.Moderators.ToList();
        }
    }
}
