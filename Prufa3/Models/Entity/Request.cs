using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prufa3.Models.Entity
{
    public class Request
    {
        public int      ID { get; set; }
        public string   Username { get; set; }
        public string   Title { get; set; }
        public string   LanguageTo { get; set; }
        public string   LanguageFrom { get; set; }
        public string   SubType { get; set; }
        public int      UpVote { get; set; }
        public DateTime RequestDate { get; set; }
        public string   Picture { get; set; }
        public string   RequestDescription { get; set; }
    }
}