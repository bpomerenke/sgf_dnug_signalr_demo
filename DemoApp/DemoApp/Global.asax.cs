using System;
using System.Web;
using System.Web.Http;

namespace DemoApp
{
    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var config = GlobalConfiguration.Configuration;
            config.Routes.MapHttpRoute(
                name: "GenericController",
                routeTemplate: "api/v1/{controller}/{id}",
                defaults: new { controller = "Info", id = RouteParameter.Optional },
                constraints: null);

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}