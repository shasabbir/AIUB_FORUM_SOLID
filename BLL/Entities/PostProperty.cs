using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    class PostProperty
    {
        public List<AnswerModel> Answers { get; set; }
        public List<CommentModel> Comments { get; set; }
        public UserModel User { get; set; }
        public PostProperty()
        {
            Answers = new List<AnswerModel>();
            Comments = new List<CommentModel>();
            User = new UserModel();
        }
    }
}
