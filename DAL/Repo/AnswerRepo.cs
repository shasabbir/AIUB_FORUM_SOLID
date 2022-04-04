using System.Collections.Generic;
using DAL.Database;

namespace DAL.Repo
{
    public class AnswerRepo : IRepositoryN<Answer, int>
    {
        private AIUB_ForumEntities db;

        public AnswerRepo(AIUB_ForumEntities db)
        {
            this.db = db;
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