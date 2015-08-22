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
                name: "InfoDefault",
                url: "",
                defaults: new { controller = "InfoWeb", action = "Info" }
            );

            routes.MapRoute(
                name: "InfoWebPage",
                url: "info",
                defaults: new { controller = "InfoWeb", action = "Info" }
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