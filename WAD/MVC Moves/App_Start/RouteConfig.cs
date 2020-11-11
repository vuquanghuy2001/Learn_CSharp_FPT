using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Moves
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name:"Hello",
            //    url:"{controller}/{action}/{name}/{id}"
            //    );

            routes.MapRoute(
                name: "Product",
                url: "{controller}/{action}/{name}/{category}/{id}"
                );

            //routes.MapRoute(
            //    name: "Welcome",
            //    url: "{controller}/{action}/{name}/{numTimes}",
            //    defaults: new { controller = "HelloWorld", action = "Welcome",numTimes=UrlParameter.Optional}
            //    ); 


            routes.MapRoute(
                name: "MyStyle",
                url: "{controller}/{action}/{name}/{numtimes}"
            );
        }
    }
}
