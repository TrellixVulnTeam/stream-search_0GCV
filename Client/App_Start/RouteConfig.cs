﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Client
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
        }
    }
}
