﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{name}/{price}",
                defaults: new { controller = "Home", action = "Index1", id = UrlParameter.Optional,name=UrlParameter.Optional,price=UrlParameter.Optional }
            );
        }
    }
}
