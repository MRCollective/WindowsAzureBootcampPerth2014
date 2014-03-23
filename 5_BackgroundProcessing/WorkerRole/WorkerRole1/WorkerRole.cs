using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace WorkerRole1
{
    public class WorkerRole : RoleEntryPoint
    {
        public override void Run()
        {
            Trace.TraceInformation("WorkerRole1 entry point called");

            while (true)
            {
                Thread.Sleep(TimeSpan.FromHours(1));
                Trace.TraceInformation("Working");
            }
        }

        public override bool OnStart()
        {
            ServicePointManager.DefaultConnectionLimit = 12;
            return base.OnStart();
        }
    }
}
