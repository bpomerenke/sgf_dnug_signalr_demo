using System.Net;
using System.Net.Http;
using DemoApp.Hubs;

namespace DemoApp.Controllers
{
    public class DotController : ApiControllerWithHub<DotHub>
    {
        public HttpResponseMessage Post()
        {
            Hub.Clients.All.broadcastMessage("", "");
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}