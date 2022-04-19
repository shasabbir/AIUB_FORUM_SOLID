using DAL.Database;
using DAL.Repo;

namespace DAL
{
    public class DataAccessFactory
    {
        static AIUB_ForumEntities _db = new AIUB_ForumEntities();
        public static IRepository<User, int, string> UserDataAccess()
        {
            return new UserRepo(_db);
        }
        public static IRepository<Post, int> PostDataAccess()
        {
            return new PostRepo(_db);
        }
        public static IRepository<Comment, int> CommentDataAccess()
        {
            return new CommentRepo(_db);
        }
        public static IRepository<Company, int> CompanyDataAccess()
        {
            return new CompanyRepo(_db);
        }
        public static IRepository<Job, int> JobDataAccess()
        {
            return new JobRepo(_db);
        }
        public static IRepository<JobPost, int> JobPostDataAccess()
        {
            return new JobPostRepo(_db);
        }
        public static IRepository<Answer, int> AnswerDataAccess()
        {
            return new AnswerRepo(_db);
        }
        public static IRepository<AnswerComment, int> AnswerCommentDataAccess()
        {
            return new AnswerCommentRepo(_db);
        }
        public static IRepository<Badge, int> BadgeDataAccess()
        {
            return new BadgeRepo(_db);
        }
        public static IRepository<Vote, int> VoteDataAccess()
        {
            return new VoteRepo(_db);
        }
        public static IRepository<Admin, int> AdminDataAccess()
        {
            return new AdminRepo(_db);
        }
        public static IRepository<Moderator, int> ModeratorDataAccess()
        {
            return new ModeratorRepo(_db);
        }

        public static IAuth<Token> AuthDataAccess()
        {
            return new AuthRepo(_db);
        }
        public static IRepository<Token, string> TokenDataAccess()
        {
            return new AuthRepo(_db);
        }


    }
}