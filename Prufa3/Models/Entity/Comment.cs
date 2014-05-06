using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prufa3.Models.Entity
{
    public class Comment
    {
        public int      ID { get; set; }
        public string   CommentText { get; set; }
        public DateTime CommentDate { get; set; }
    }
}