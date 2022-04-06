using System.Collections.Generic;
using DAL.Database;

namespace DAL.Repo
{
    public class CommentRepo : IRepository<Comment, int>
    {
        private AIUB_ForumEntities db;

        public CommentRepo(AIUB_ForumEntities db)
        {
            this.db = db;
        }

        public bool Add(Comment obj)
        {
            throw new System.NotImplementedException();
        }

        public Comment Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Comment> Get()
        {
            throw new System.NotImplementedException();
        }

        public bool Edit(Comment obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}