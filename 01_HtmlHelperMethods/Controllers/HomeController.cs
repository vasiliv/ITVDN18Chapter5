using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_HtmlHelperMethods.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.WeekDays = new string[] {"Monday", "Tuesday", "Wednesday"};
            ViewBag.Fruits = new string[] { "Mango", "Kiwi", "Cinamon" };
            return View();
        }
    }
}