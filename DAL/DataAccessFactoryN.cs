using DAL.Database;
using DAL.Repo;

namespace DAL
{
    public class DataAccessFactoryN
    {
        static AIUB_ForumEntities db = new AIUB_ForumEntities();
        public static IRepositoryN<User,int> UserDataAccess() {
            return new UserRepo(db);
        }
        public static IRepositoryN<Post, int> PostDataAccess()
        {
            return new PostRepo(db);
        }
        public static IRepositoryN<Comment, int> CommentDataAccess()
        {
            return new CommentRepo(db);
        }
        public static IRepositoryN<Company, int> CategoryDataAccess()
        {
            return new CompanyRepo(db);
        }
        public static IRepositoryN<Job, int> JobDataAccess()
        {
            return new JobRepo(db);
        }
        public static IRepositoryN<Answer, int> AnswerDataAccess()
        {
            return new AnswerRepo(db);
        }
        public static IRepositoryN<AnswerComment, int> AnswerCommentDataAccess()
        {
            return new AnswerCommentRepo(db);
        }
        public static IRepositoryN<Badge, int> BadgeDataAccess()
        {
            return new BadgeRepo(db);
        }
        public static IRepositoryN<Vote, int> VoteDataAccess()
        {
            return new VoteRepo(db);
        }
        
        

        public static IAuth AuthAccess() {
            return new UserRepo(db);
        }
    }
}