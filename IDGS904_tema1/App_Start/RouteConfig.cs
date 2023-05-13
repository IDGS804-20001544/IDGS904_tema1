﻿using System.Web.Mvc;
using System.Web.Routing;

namespace IDGS904_tema1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Distancia", action = "Distancia", id = UrlParameter.Optional }
            );
        }
    }
}
