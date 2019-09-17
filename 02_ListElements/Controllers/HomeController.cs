using _02_ListElements.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_ListElements.Controllers {
    public class HomeController : Controller {
        [HttpGet]
        public ActionResult Index() {
            List<Product> Products = new List<Product> {
                new Product{Id = 1, Name = "Product1"},
                new Product{Id = 2, Name = "Product2"},
                new Product{Id = 3, Name = "Product3"},
                new Product{Id = 4, Name = "Product4"}
            };
            ViewBag.Products = new SelectList(Products, "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Index (string Products) {
            return View("Selected", (object)Products);
        }
    }
}