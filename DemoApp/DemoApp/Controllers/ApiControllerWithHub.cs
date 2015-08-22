using System;
using System.Web.Http;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace DemoApp.Controllers
{
    public abstract class ApiControllerWithHub<THub> : ApiController
    where THub : IHub
    {
        Lazy<IHubContext> hub = new Lazy<IHubContext>(
            () => GlobalHost.ConnectionManager.GetHubContext<THub>()
        );

        protected IHubContext Hub
        {
            get { return hub.Value; }
        }

       
        internal string GetUsername()
        {
            var ipAddress = GetIpAddress();
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
}