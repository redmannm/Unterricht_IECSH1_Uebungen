﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uebung10_Bibliothek_DB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome, to your new MVC application!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
