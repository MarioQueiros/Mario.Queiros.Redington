using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Redington
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters( GlobalFilters.Filters );
            RouteConfig.RegisterRoutes( RouteTable.Routes );
            BundleConfig.RegisterBundles( BundleTable.Bundles );

            RouteTable.Routes.MapRoute(
                "Form",
                "{controller}/{action}/{probabalityOne}/{probabalityTwo}/{selectedOption}/{result}",
                new { controller = "Home", action = "Form", probabalityOne = @"\d+(\.\d{1,2})?", probabalityTwo = @"\d+(\.\d{1,2})?", selectedOption = "[0-1]", result = @"\d+(\.\d{1,2})?" }
                );
        }
    }
}
