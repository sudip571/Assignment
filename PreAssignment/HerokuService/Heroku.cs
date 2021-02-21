using PreAssignment.Services;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Triggers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace HerokuService
{
    partial class Heroku : ServiceBase
    {
        private static IScheduler _scheduler;
        public Heroku()
        {
            InitializeComponent();
        }
        private static void HerokuAPIJob()
        {
            var myJob1 = new Jobs.HerokuAPIJob();
            var jobDetail1 = new JobDetailImpl("Job1", "Group1", myJob1.GetType());
            //every 1 hour
            var trigger1 = new CronTriggerImpl("Trigger1", "Group1", "0 0 0/1 1/1 * ? *");
            _scheduler.ScheduleJob(jobDetail1, trigger1);
        }
       
        protected override void OnStart(string[] args)
        {
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            _scheduler = schedulerFactory.GetScheduler();
            _scheduler.Start();

            Task.Factory.StartNew(HerokuAPIJob);
            //Add other job here
            //Task.Factory.StartNew(HerokuAPI2Job);
            
        }

        protected override void OnStop()
        {
            _scheduler.Shutdown();
        }
        #region for Debugging only
        public void StartDebug()
        {
            try
            {
                var service = new ProductService();
                service.HerokuAPIRequest().Wait();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }

}
