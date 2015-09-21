using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5_SO_32669600
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // This will match URLs 4 or 5 segments in length such as:
            //
            //   /Home/Index/2/3
            //   /Home/Index/2/3/4
            //
            routes.MapRoute(
                name: "4-5Segments",
                url: "{controller}/{action}/{id}/{id2}/{id3}",
                defaults: new { id3 = UrlParameter.Optional }
            );

            // This will match URLs 0, 1, 2, or 3 segments in length such as:
            //
            //   /
            //   /Home
            //   /Home/Index/
            //   /Home/Index/2
            //
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
