using _03_HtmlFormSample.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_HtmlFormSample.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        [HttpGet]
        public ActionResult Create() {
            TaskModel model = new TaskModel();
            model.Name = "Vasil";
            model.Completed = false;
            model.StartDate = DateTime.Now.ToShortDateString();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(TaskModel incomingData) {
            Debug.WriteLine("Name = " + incomingData.Name);
            Debug.WriteLine("StartDate = " + incomingData.StartDate);
            Debug.WriteLine("Completed = " + incomingData.Completed);
            return View("Success");
        }
    }
}