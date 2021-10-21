using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace view_ornek.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult References()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        // mvcaction4 
    }
}