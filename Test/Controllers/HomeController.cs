using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        [HttpPost]
        public ActionResult Subscribe(SubscribeModel model) {
            if (ModelState.IsValid) {
                ViewBag.Text = model.Email;
            }
            return View("Index", model);
        }
    }
}