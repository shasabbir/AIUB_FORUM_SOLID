using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    public class BadgeRepo : IRepository<Badge, int>
    {
        private readonly AIUB_ForumEntities _db;

        public BadgeRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }
        public bool Add(Badge obj)
        {
            _db.Badges.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public Badge Get(int id)
        {
            return _db.Badges.FirstOrDefault(x => x.BadgeId == id);
        }

        public List<Badge> Get()
        {
            return _db.Badges.ToList();
        }

        public bool Edit(Badge obj)
        {
            var p = _db.Badges.FirstOrDefault(en => en.BadgeId == obj.BadgeId);
            _db.Entry(p).CurrentValues.SetValues(obj);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = _db.Badges.FirstOrDefault(e => e.BadgeId == id);
            if (c == null)
            {
                return false;
            }

            _db.Badges.Remove(c);
            return true;
        }

    }
}
