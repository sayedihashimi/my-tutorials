using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers {
    public class HelloWorldController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Welcome(string name ="Demo", int numTimes = 5) {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}