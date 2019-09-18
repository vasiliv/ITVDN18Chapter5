using HomeworkAdditionalCalc.Content;
using System.Web.Mvc;

namespace HomeworkAdditionalCalc.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }        
        [HttpPost]
        public ActionResult Plus(Calculator calculator) {
            ViewBag.Result = calculator.txtBox1 + calculator.txtBox2;            
            return View("Index", calculator);
        }
        [HttpPost]
        public ActionResult Minus(Calculator calculator) {
            ViewBag.Result = calculator.txtBox1 - calculator.txtBox2;            
            return View("Index", calculator);
        }
        [HttpPost]
        public ActionResult Multiply(Calculator calculator) {
            ViewBag.Result = calculator.txtBox1 * calculator.txtBox2;
            return View("Index", calculator);
        }
        [HttpPost]
        public ActionResult Divide(Calculator calculator) {
            ViewBag.Result = calculator.txtBox1 / calculator.txtBox2;
            return View("Index", calculator);
        }
    }
}