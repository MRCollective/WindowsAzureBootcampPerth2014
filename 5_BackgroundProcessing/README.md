Background Processing
=====================

This is a demo plan for demonstrating some of the background processing options in Windows Azure.

Preparation
-----------

1. Deploy the [Worker Role](WorkerRole) project
2. Build the [Web Job](WebJob) project, zip the contents of the `bin` directory and upload it to the WebJobs tab of a Web Site and set up the data and runtime storage account for that Web Site
3. Create a Scheduled Job in the portal to insert a queue message every hour

Demo
----

1. Demonstrate the Worker Role instance in the portal, code in `RoleEntryPoint` in Visual Studio and the `WADLogsTable` in the diagnostics storage account
2. Demonstrate the Web Job code in visual Studio, drop sample.png into the blob storage and wait for it to be processed, demonstrate the logs at:
    * [https://<site>.scm.azurewebsites.net/vfs/data/jobs/continuous/PngQuantisation/job_log.txt](https://<site>.scm.azurewebsites.net/vfs/data/jobs/continuous/PngQuantisation/job_log.txt)
    * [https://<site>.scm.azurewebsites.net/azurejobs/](https://<site>.scm.azurewebsites.net/azurejobs/)
3. Show the queue messages from the scheduled job and also show the setup and execution logs in the portal
