using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prufa3.Models.Entity
{
    public class Comment
    {
        // Eigindi fyrir umsagnir --------------------------------------------------------
        [Key]       // Frumlykill
        public int      CommentId { get; set; }
        [Required]  // Ekki nullable
        public string   CommentText { get; set; }
        // Synir bara dagsetningu - tekur ut klukkuna
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CommentDate { get; set; }
        // -------------------------------------------------------------------------------
    }
}