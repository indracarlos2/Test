using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RestorationStore {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("CreateRequest", "Extra/Contact/User/Form",
                        new { controller = "Request",
                        action="Index"});

            routes.MapRoute("ListResponses", "jobs/previous",
                        new {
                            controller = "Response",
                            action = "GetAllResponses"
                        });

            routes.MapRoute("ListRequest", "jobs/pendings",
                        new {
                            controller = "RequestPending",
                            action = "Index"
                        });

            routes.MapRoute("Home", "home",
                        new {
                            controller = "Home",
                            action = "Index"
                        });

            routes.MapRoute("DetailResponse", "jobs/previous/{id}/entry",
                        new {
                            controller = "Response",
                            action = "DetailResponse"
                        });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}