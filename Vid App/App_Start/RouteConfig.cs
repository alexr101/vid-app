using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vid_App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); // Allows us to use route contraints in the controller!

            // This route is good and all but it's very inflexible and filled w
            // magic strings. Use MVC Attribute Routes intead
            //routes.MapRoute(
            //    "MoviesByReleaseDate", 
            //    "movies/released/{year}/{month}",
            //    new { controller = "Movies", action = "ByReleaseDate" },
            //    new { year = @"/d{4}", month = @"/d{2}" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
