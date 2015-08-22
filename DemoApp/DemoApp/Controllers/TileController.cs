using System.Net;
using System.Net.Http;
using DemoApp.Hubs;

namespace DemoApp.Controllers
{
    public class TileController : ApiControllerWithHub<TileHub>
    {
        public HttpResponseMessage Post(TileInfo tileInfo)
        {
            var username = GetUsername();
            Hub.Clients.All.broadcastMessage(username, tileInfo.Color);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }

    public class TileInfo
    {
        public string Color { get; set; }
    }
}