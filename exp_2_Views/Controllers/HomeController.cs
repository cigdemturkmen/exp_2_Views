using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exp_2_Views.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() // home/index ... sadece home yazsak da index actionı çalışır
        {
            return View();
        }

        // action (method)
        public ActionResult AboutUs() // home/aboutus  // actionresult bir view döndürme işlemi. bir metot. 
        {
            return View();
        }

        public ActionResult Contact() // home/contact
        {
            return View();
        }
    }
}