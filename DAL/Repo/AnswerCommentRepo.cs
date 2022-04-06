using System.Collections.Generic;
using DAL.Database;

namespace DAL.Repo
{
    public class AnswerCommentRepo : IRepository<AnswerComment, int>
    {
        private AIUB_ForumEntities db;

        public AnswerCommentRepo(AIUB_ForumEntities db)
        {
            this.db = db;
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