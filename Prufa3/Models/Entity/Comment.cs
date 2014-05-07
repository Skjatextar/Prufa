using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prufa3.Models.Entity
{
    public class Comment
    {
        [Key]
        public int      CommentId { get; set; }
        [Required]
        public string   CommentText { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CommentDate { get; set; }
    }
}