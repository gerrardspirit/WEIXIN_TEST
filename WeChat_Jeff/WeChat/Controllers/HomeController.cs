﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            ViewBag.Title = "Home Page" + id;

            return View();
        }
    }
}