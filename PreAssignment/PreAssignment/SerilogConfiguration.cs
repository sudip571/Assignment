using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreAssignment
{
    public static class SerilogConfiguration
    {
        public static void configSerilog()
        {
            Log.Logger = new LoggerConfiguration()
                        .WriteTo.File(@"C:\logg\log.txt", rollingInterval: RollingInterval.Day)
                        .CreateLogger();
        }
    }
}