using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class UserComment
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
