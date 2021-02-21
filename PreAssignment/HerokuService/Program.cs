using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace HerokuService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Heroku()
            };
            ServiceBase.Run(ServicesToRun);
            //this is only for debugging purpose
            //Disable above line of codes and enable this line of codes
            //Heroku serviceDebug = new Heroku();
            //serviceDebug.StartDebug();
        }
    }
}
