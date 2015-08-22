using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class InfoWebController : Controller
    {
        public ViewResult Info()
        {
            var info = new Info {AppName = "DemoApp"};
            return View(info);
        }
    }
}