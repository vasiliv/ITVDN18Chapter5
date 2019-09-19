using Homework2Webgrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework2Webgrid.Controllers {
    public class HomeController : Controller {
        List<Product> products = new List<Product> {
            new Product{Id = 1, Name = "Product1", Price = 2, Description = "Product1"},
            new Product{Id = 2, Name = "Product2", Price = 3, Description = "Product2"},
            new Product{Id = 3, Name = "Product3", Price = 4, Description = "Product3"}
        };
        public ActionResult Index() {
            return View(products);
        }
    }
}