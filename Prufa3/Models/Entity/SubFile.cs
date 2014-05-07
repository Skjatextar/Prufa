using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace Prufa3.Models.Entity
{
    public class SubFile
    {
        // Eigindi fyrir textaskrar ------------------------------------------------------
        [Key]       // Frumlykill
        public int      SubFileId { get; set; }
        [Required]  // Ekki nullable
        public string   Title { get; set; }
        // Tungumal thydingar
        public string   SubLanguage { get; set; }
        // Gerd textaskrar - kvikmynd/thattur
        public string   SubType { get; set; }
        // Flokkur textaskrar - t.d. spennumynd/drama
        public string   Genre { get; set; }
        // Synir bara dagsetningu - tekur ut klukkuna
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime SubDate { get; set; }
        // Slod ad mynd fyrir skrana
        public string   Picture { get; set; }
        // Lysing a thydingu
        public string   SubDescription { get; set; }
        // Slod ad textaskra
        public string   FilePath { get; set; }
        // Talning a hve oft hefur verid likad vid gaedi textaskrar
        public int      UpVote { get; set; }
        // -------------------------------------------------------------------------------

        // Adkomylyklar ------------------------------------------------------------------
        // (one-to-one) - tenging i notanda
        public int ClientId { get; set; }
        // (one-to-one) - tenging i notanda
        public int RequestId { get; set; }
        // (one-to-many) - listi af umsognum
        public virtual ICollection<Comment> Comments { get; set; }
        // -------------------------------------------------------------------------------
    }
}