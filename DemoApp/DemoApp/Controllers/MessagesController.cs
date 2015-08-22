using System.Net;
using System.Net.Http;
using DemoApp.Hubs;

namespace DemoApp.Controllers
{
    public class MessagesController : ApiControllerWithHub<MessagesHub>
    {
        public HttpResponseMessage Post(MessageInfo messageInfo)
        {
            var username = GetUsername();
            Hub.Clients.All.broadcastMessage(username, messageInfo.Message);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

    }

    public class MessageInfo
    {
        public string Message { get; set; }
    }
}