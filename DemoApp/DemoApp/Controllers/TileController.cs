using System.Net;
using System.Net.Http;
using DemoApp.Hubs;

namespace DemoApp.Controllers
{
    public class TileController : ApiControllerWithHub<TileHub>
    {
        public HttpResponseMessage Post(TileInfo tileInfo)
        {
            var ipAddress = GetIpAddress();
            var username = GetUsername(ipAddress);
            Hub.Clients.All.broadcastMessage(username, tileInfo.Color);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        private string GetUsername(string ipAddress)
        {
            if (HomeWebController.IpDictionary.ContainsKey(ipAddress))
            {
                return HomeWebController.IpDictionary[ipAddress];
            }
            return null;
        }

        private string GetIpAddress()
        {
            dynamic ipProp = Request.Properties["MS_HttpContext"];
            var ipAddress = ipProp.Request.UserHostAddress;
            return ipAddress;
        }
    }

    public class TileInfo
    {
        public string Color { get; set; }
    }
}