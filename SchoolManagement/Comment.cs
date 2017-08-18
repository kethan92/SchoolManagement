using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Comment
    {
        private List<string> comment;

        public Comment()
        {
            comment = new List<string>();
        }
        public void addComment(string stringComment)
        {
            this.comment.Add(stringComment);
        }
    }
}
