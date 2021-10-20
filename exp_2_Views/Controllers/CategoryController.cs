using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exp_2_Views.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult List()
        {
            // db'den tüm kategorileri çek ve view'e gönder.
            return View();
        }

        public ActionResult Index()
        {
            
            return View("List"); // Index'in view'ı yokseni list'in viewina yönlendiriyor. farklı isimdeki actionı gönderme işlemi.her actionın bir viewı olmak zorunda değil.
        }
    }
}