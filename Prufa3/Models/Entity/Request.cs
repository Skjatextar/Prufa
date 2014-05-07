using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prufa3.Models.Entity
{
    public class Request
    {
        [Key]
        public int      RequestId { get; set; }
        [Required]
        public string   Username { get; set; }
        [Required]
        public string   Title { get; set; }
        public string   LanguageTo { get; set; }
        public string   LanguageFrom { get; set; }
        public string   SubType { get; set; }
        public int      UpVote { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime RequestDate { get; set; }
        public string   Picture { get; set; }
        public string   RequestDescription { get; set; }

        // Adkomulykill (one-to-one) - tenging i textaskra
        public int SubFileId { get; set; }
        // Adkomulykill (one-to-many) - listi af umsognum
        public virtual ICollection<Comment> Comments { get; set; }
        // Adkomulykill (one-to-one) - tenging i notanda
        public string ClientId { get; set; }
    }
}