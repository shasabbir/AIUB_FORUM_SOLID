using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class BadgeRepo : IRepository<Badge, int>
    {
        private AIUB_ForumEntities db;

        public BadgeRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }
        public bool Add(Badge obj)
        {
            db.Badges.Add(obj);
            return db.SaveChanges() != 0;
        }

        public Badge Get(int id)
        {
            return db.Badges.FirstOrDefault(x => x.BadgeId == id);
        }

        public List<Badge> Get()
        {
            return db.Badges.ToList();
        }

        public bool Edit(Badge obj)
        {
            var p = db.Badges.FirstOrDefault(en => en.BadgeId == obj.BadgeId);
            db.Entry(p).CurrentValues.SetValues(obj.BadgeId);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = db.Badges.FirstOrDefault(e => e.BadgeId == id);
            if (c == null)
            {
                return false;
            }

            db.Badges.Remove(c);
            return true;
        }

    }
}
