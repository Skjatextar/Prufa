using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prufa3.Models.Entity
{
    public class Client
    {
        [Key]
        public string   Username { get; set; }
        [Required]
        public string   Pass { get; set; }
        [Required]
        public string   Email { get; set; }
        public int      Ranking { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime SignupDate { get; set; }
        public int      Theme { get; set; }

        // Adkomulykill (one-to-many) - listi af beidnum
        public virtual ICollection<Request> Requests { get; set; }
        // Adkomulykill (one-to-many) - listi af skram
        public virtual ICollection<SubFile> SubFiles { get; set; }
        // Adkomulykill (one-to-many) - listi af umsognum
        public virtual ICollection<Comment> Comments { get; set; }
    }
}