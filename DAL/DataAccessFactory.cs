using DAL.Database;
using DAL.Repo;

namespace DAL
{
    public class DataAccessFactory
    {
        static AIUB_ForumEntities db = new AIUB_ForumEntities();
        public static IRepository<User, int> UserDataAccess()
        {
            return new UserRepo(db);
        }
        public static IRepository<Post, int> PostDataAccess()
        {
            return new PostRepo(db);
        }
        public static IRepository<Comment, int> CommentDataAccess()
        {
            return new CommentRepo(db);
        }
        public static IRepository<Company, int> CompanyDataAccess()
        {
            return new CompanyRepo(db);
        }
        public static IRepository<Job, int> JobDataAccess()
        {
            return new JobRepo(db);
        }
        public static IRepository<JobPost, int> JobPostDataAccess()
        {
            return new JobPostRepo(db);
        }
        public static IRepository<Answer, int> AnswerDataAccess()
        {
            return new AnswerRepo(db);
        }
        public static IRepository<AnswerComment, int> AnswerCommentDataAccess()
        {
            return new AnswerCommentRepo(db);
        }
        public static IRepository<Badge, int> BadgeDataAccess()
        {
            return new BadgeRepo(db);
        }
        public static IRepository<Vote, int> VoteDataAccess()
        {
            return new VoteRepo(db);
        }



        public static IAuth AuthAccess()
        {
            return new UserRepo(db);
        }
    }
}