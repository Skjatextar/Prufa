using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prufa3.App_Data.DataAccessLayer;
using Prufa3.Models.Entity;

namespace Prufa3.Models.ViewModel
{
    public class SubFileViewModel
    {
        // Tennging i gagnagrunn - breytist thegar repos. koma inn
        private SubDataContext db = new SubDataContext();

        public IEnumerable<Prufa3.Models.Entity.Client>  ClientData { get; set; }
        public IEnumerable<Prufa3.Models.Entity.Comment> CommentData { get; set; }
        public IEnumerable<Prufa3.Models.Entity.Request> RequestData { get; set; }
        public IEnumerable<Prufa3.Models.Entity.SubFile> SubFileData { get; set; }
    }
}