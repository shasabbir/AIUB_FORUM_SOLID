using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class CommentModel
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public string Score { get; set; }
        public string Text { get; set; }
        public System.DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
