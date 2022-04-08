using DAL.Database;
using System.Collections.Generic;

namespace DAL.Repo
{
    public class AnswerCommentRepo : IRepository<AnswerComment, int>
    {
        private AIUB_ForumEntities _db;

        public AnswerCommentRepo(AIUB_ForumEntities db)
        {
            this._db = db;
        }

        public bool Add(AnswerComment obj)
        {
            throw new System.NotImplementedException();
        }

        public AnswerComment Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<AnswerComment> Get()
        {
            throw new System.NotImplementedException();
        }

        public bool Edit(AnswerComment obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}