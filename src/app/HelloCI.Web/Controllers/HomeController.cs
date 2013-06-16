using System.Web.Mvc;

namespace HelloCI.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello CI Demo";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Hello CI Demo";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
