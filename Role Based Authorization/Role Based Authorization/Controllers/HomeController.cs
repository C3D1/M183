﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Role_Based_Authorization.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        [HttpPost]
        public ActionResult Login()
        {
            var username = Request["username"];
            var password = Request["password"];

            if (username == "admin" && password == "test")
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            else if (username == "user" && password == "test")
            {
                return RedirectToAction("Dashboard", "User");
            }
            else
            {
                ViewBag.Message = "Wrong Credentials";
            }

            return View();
        }
    }
}