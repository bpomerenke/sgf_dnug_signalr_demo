using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoApp
{
    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();

            var config = GlobalConfiguration.Configuration;
            config.Routes.MapHttpRoute(
                name: "GenericController",
                routeTemplate: "api/v1/{controller}/{id}",
                defaults: new { controller = "Info", id = RouteParameter.Optional },
                constraints: null);


            var routes = RouteTable.Routes;
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "DefaultRoute",
                url: "",
                defaults: new { controller = "HomeWeb", action = "Index" }
            );

            routes.MapRoute(
                name: "GenericWebRoute",
                url: "{controller}/{action}",
                defaults: new { controller = "HomeWeb", action = "Index" }
            );

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