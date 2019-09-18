using HomeworkAdditionalCalc.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkAdditionalCalc.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        [HttpGet]
        public ActionResult Plus() {
            Calculator calculator = new Calculator();

            return View(calculator);
        }
        [HttpPost]
        public ActionResult Plus(Calculator calculator) {
            ViewBag.Result = calculator.txtBox1 + calculator.txtBox2;
            //return View();
            return View("Index", calculator);
        }
    }
}