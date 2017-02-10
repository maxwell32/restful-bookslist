﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace book_api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //title of webpage
            ViewBag.Title = "RESTful Books GET API";

            return View();
        }
    }
}
