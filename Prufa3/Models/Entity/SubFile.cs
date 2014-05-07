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
        [Key]
        public int      SubFileId { get; set; }
        [Required]
        public string   Title { get; set; }
        public string   SubLanguage { get; set; }
        public string   SubType { get; set; }
        public string   Genre { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime SubDate { get; set; }
        public string   Picture { get; set; }
        public string   SubDescription { get; set; }
        public string   FilePath { get; set; }
        public int      UpVote { get; set; }

        // Adkomulykill (one-to-one) - tenging i notanda
        public int ClientId { get; set; }
        // Adkomulykill (one-to-one) - tenging i notanda
        public int RequestId { get; set; }
        // Adkomulykill (one-to-many) - listi af umsognum
        public virtual ICollection<Comment> Comments { get; set; }

    }
}