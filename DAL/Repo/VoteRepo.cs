using System.Collections.Generic;
using System.Linq;
using DAL.Database;

namespace DAL.Repo
{
    internal class VoteRepo : IRepository<Vote, int>
    {
        private AIUB_ForumEntities db;

        public VoteRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }

        public bool Add(Vote obj)
        {
            db.Votes.Add(obj);
            return db.SaveChanges() != 0;
        }

        public Vote Get(int id)
        {
            return db.Votes.FirstOrDefault(x => x.VoteId == id);;
        }

        public List<Vote> Get()
        {
            return db.Votes.ToList();
        }

        public bool Edit(Vote obj)
        {
            var p = db.Votes.FirstOrDefault(en => en.VoteId == obj.VoteId);
            db.Entry(p).CurrentValues.SetValues(obj.VoteId);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var c = db.Votes.FirstOrDefault(e => e.VoteId == id);
            if (c == null) return false;
            db.Votes.Remove(c);
            return true;
        }
    }
}
