using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prufa3.Models;
using Prufa3.Models.Interface;

namespace Prufa3.Controllers
{
    public class SubFileController : Controller
    {
        //
        // GET: /SubFile/

        private readonly ISubFileRepository _repo;

        public SubFileController(ISubFileRepository repo)
        {
            _repo = repo;
        }

        //public ActionResult Index()
        //{
        //    var result = (from s in _repo.GetSubFiles()
        //        //orderby s.sUsername descending
        //        select s);

        //    return View(result);
        //}
	}
}