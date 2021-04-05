using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Like
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
