using PreAssignment.Services;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuService
{
    public static class Jobs
    {
        [DisallowConcurrentExecution]
        internal class HerokuAPIJob : IJob
        {
            public void Execute(IJobExecutionContext context)
            {
                try
                {
                    // call service to be executed
                    var service = new ProductService();
                    service.HerokuAPIRequest().Wait();
                }
                catch (Exception ex)
                {
                    // keep loging
                   
                }
            }
        }

       
    }
}

