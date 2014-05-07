﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prufa3.App_Data.DataAccessLayer;
using StudentApplication.Models;
using Prufa3.Models;

namespace Prufa3.Controllers
{
    public class HomeController : Controller
    {
        private SubDataContext db = new SubDataContext();

        public ActionResult Index()
        {
            StudentRepository repository = new StudentRepository();
            var model = repository.GetAllStudents();
            return View(model);
        }

        public ActionResult Search()
        {
            ViewBag.Message = "Beiðni Leit";

            return View();
        }

        public ActionResult FileForm()
        {
            ViewBag.Message = "Senda inn skrá";

            return View();
        }

        public ActionResult NewForm()
        {
            ViewBag.Message = "Ný beiðni";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(db.Clients.ToList());
        }
    }
}