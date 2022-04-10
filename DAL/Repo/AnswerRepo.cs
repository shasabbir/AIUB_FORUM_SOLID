using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AnswerRepo : IRepository<Answer,int>
    {
        private AIUB_ForumEntities db;
        public AnswerRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }
        public bool Add(Answer obj)
        {
            db.Answers.Add(obj);
            return db.SaveChanges() != 0;
        }

        public bool Delete(int id)
        {
            var oobj = db.Answers.FirstOrDefault(x => x.AnsId == id);
            if (oobj == null) return false;
            db.Answers.Remove(oobj);
            if (db.SaveChanges() == 1) { return true; }
            return false;
        }

        public bool Edit(Answer obj)
        {
            var oobj = db.Answers.FirstOrDefault(x => x.AnsId == obj.AnsId);
            db.Entry(oobj).CurrentValues.SetValues(obj);
            return db.SaveChanges() != 0;
        }

        public Answer Get(int id)
        {
            return db.Answers.FirstOrDefault(x => x.AnsId == id);
        }

        public List<Answer> Get()
        {
            return db.Answers.ToList();
        }
    }
}
