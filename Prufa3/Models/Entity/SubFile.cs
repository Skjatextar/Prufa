using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace Prufa3.Models.Entity
{
    public class SubFile
    {
        public int      ID { get; set; }
        public string   Title { get; set; }
        public string   SubLanguage { get; set; }
        public string   SubType { get; set; }
        public string   Genre { get; set; }
        public DateTime SubDate { get; set; }
        public string   Picture { get; set; }
        public string   SubDescription { get; set; }
        public string   FilePath { get; set; }
        public int      UpVote { get; set; }
    }
}