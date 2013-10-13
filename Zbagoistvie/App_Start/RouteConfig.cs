using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Zbagoistvie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Fail",
                url: "Fail",
                defaults: new { controller = "Home", action = "Fail" }
            );

            routes.MapRoute(
                name: "Order",
                url: "Order/{id}",
                defaults: new { controller = "Home", action = "Order", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Success",
                url: "Success",
                defaults: new { controller = "Home", action = "Success" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}