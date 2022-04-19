using DAL.Database;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repo
{
    internal class VoteRepo : IRepository<Vote, int>
    {
        private readonly AIUB_ForumEntities _db;

        public VoteRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }

        public bool Add(Vote obj)
        {
            _db.Votes.Add(obj);
            return _db.SaveChanges() != 0;
        }

        public Vote Get(int id)
        {
            return _db.Votes.FirstOrDefault(x => x.VoteId == id);
        }

        public List<Vote> Get()
        {
            return _db.Votes.ToList();
        }

        public bool Edit(Vote obj)
        {
            var p = _db.Votes.FirstOrDefault(en => en.VoteId == obj.VoteId);
            _db.Entry(p).CurrentValues.SetValues(obj);
            return _db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = _db.Votes.FirstOrDefault(e => e.VoteId == id);
            if (c == null)
            {
                return false;
            }

            _db.Votes.Remove(c);
            return true;
        }
    }
}
