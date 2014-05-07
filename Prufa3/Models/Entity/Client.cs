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
        // Eigindi fyrir notanda ---------------------------------------------------------
        [Key]       // Frumlykill
        public string   Username { get; set; }
        [Required]  // Ekki nullable
        public string   Pass { get; set; }
        [Required]  // Ekki nullable
        public string   Email { get; set; }
        // Notandi faer tign med ordum en her er thad taknad med tolum fra t.d. 1-5
        public int      Ranking { get; set; }
        // Synir bara dagsetningu - tekur ut klukkuna
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime SignupDate { get; set; }
        // Notandi getur valid um themu numerud fra t.d. 1-3
        public int      Theme { get; set; }
        // -------------------------------------------------------------------------------

        // Adkomulyklar ------------------------------------------------------------------
        // (one-to-many) - listi af beidnum
        public virtual ICollection<Request> Requests { get; set; }
        // (one-to-many) - listi af skram
        public virtual ICollection<SubFile> SubFiles { get; set; }
        // (one-to-many) - listi af umsognum
        public virtual ICollection<Comment> Comments { get; set; }
        // -------------------------------------------------------------------------------
    }
}