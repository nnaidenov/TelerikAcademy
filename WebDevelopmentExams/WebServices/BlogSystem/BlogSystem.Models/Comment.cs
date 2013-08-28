using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSystem.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }

        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
}