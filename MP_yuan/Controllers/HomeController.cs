using System.Web.Mvc;

namespace MP_yuan.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Message = "Checkout my resume:)";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Let's Connect!!!";
            

            return View();
        }
    }
}