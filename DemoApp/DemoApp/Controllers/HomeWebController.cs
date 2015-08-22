using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class HomeWebController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}