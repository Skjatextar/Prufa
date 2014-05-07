using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prufa3.Models.Entity
{
    public class Request
    {
        // Eigindi fyrir beidnir ---------------------------------------------------------
        [Key]       // Frumlykill
        public int      RequestId { get; set; }
        [Required]  // Ekki nullable
        public string   Username { get; set; }
        [Required]  // Ekki nullable
        public string   Title { get; set; }
        // Tungumal sem a ad thyda i
        public string   LanguageTo { get; set; }
        // Tungumal sem a ad thyda fra
        public string   LanguageFrom { get; set; }
        // Gerd textaskrar - kvikmynd/thattur
        public string   SubType { get; set; }
        // Talning a hve oft hefur verid likad vid beidni (thrystingur a thydingu)
        public int      UpVote { get; set; }
        // Synir bara dagsetningu - tekur ut klukkuna
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime RequestDate { get; set; }
        // Slod ad mynd fyrir skrana
        public string   Picture { get; set; }
        // Lysing/texti fyrir beidni
        public string   RequestDescription { get; set; }
        // -------------------------------------------------------------------------------

        // Adkomulyklar ------------------------------------------------------------------
        // (one-to-one) - tenging i textaskra
        public int      SubFileId { get; set; }
        // (one-to-many) - listi af umsognum
        public virtual  ICollection<Comment> Comments { get; set; }
        // (one-to-one) - tenging i notanda
        public string   ClientId { get; set; }
        // -------------------------------------------------------------------------------
    }
}