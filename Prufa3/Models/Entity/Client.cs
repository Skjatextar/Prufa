using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prufa3.Models.Entity
{
    public class Client
    {
        public string   Username { get; set; }
        public string   Pass { get; set; }
        public string   Email { get; set; }
        public int      Ranking { get; set; }
        public DateTime SignupDate { get; set; }
        public int      Theme { get; set; }
    }
}