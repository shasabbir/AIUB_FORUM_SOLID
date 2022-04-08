using DAL.Database;
using System.Collections.Generic;

namespace DAL.Repo
{
    public class AnswerRepo : IRepository<Answer, int>
    {
        private AIUB_ForumEntities _db;

        public AnswerRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }

        public bool Add(Answer obj)
        {
            throw new System.NotImplementedException();
        }

        public Answer Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Answer> Get()
        {
            throw new System.NotImplementedException();
        }

        public bool Edit(Answer obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}