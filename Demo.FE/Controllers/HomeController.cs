using System.Web.Mvc;

namespace Hourly.FE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}