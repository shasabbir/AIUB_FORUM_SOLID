using DAL.Database;
using System.Collections.Generic;

namespace DAL.Repo
{
    public class CommentRepo : IRepository<Comment, int>
    {
        private AIUB_ForumEntities _db;

        public CommentRepo(AIUB_ForumEntities db)
        {
            this._db = db;
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