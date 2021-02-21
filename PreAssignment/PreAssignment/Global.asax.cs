using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PreAssignment
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Setup Serilog for logging
            //Log.Logger = new LoggerConfiguration()
            //            .WriteTo.File(@"C:\logg\log.txt", rollingInterval: RollingInterval.Day)                        
            //            .CreateLogger();

            SerilogConfiguration.configSerilog();
        }
    }
}
