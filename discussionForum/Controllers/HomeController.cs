﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace discussionForum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // hello okay HEllo hello hello

            // hello this is a new line
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}