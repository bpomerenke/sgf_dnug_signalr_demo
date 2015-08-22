using System.Web.Http;

namespace DemoApp.Controllers
{
    public class InfoController : ApiController
    {
        public Info Get()
        {
            return new Info {AppName = "DemoApp"};
        }
    }

    public class Info
    {
        public string AppName { get; set; }
    }
}