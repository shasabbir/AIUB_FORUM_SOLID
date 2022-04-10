using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class AnswerProperty
    {
        public List<AnswerCommentModel> AnswerComments { get; set; }
        public UserModel User { get; set; }
        public AnswerProperty()
        {
            AnswerComments = new List<AnswerCommentModel>();
            User = new UserModel();
        }
    }
}
