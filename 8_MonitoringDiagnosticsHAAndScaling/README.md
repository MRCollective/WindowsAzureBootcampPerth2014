Monitoring, Diagnostics, High Availability and Scaling
=====================

This is a demo plan for demonstrating monitoring, diagnostics, high availability and scaling in Windows Azure.

Preparation
-----------

1. Configure and publish a new Azure Web Site.
2. Check New Relic is not already added via the Azure Store given this demo will show how to enable it that way.

Demo
----

### Monitoring
1. Explain and show basic CPU/memory monitoring
2. In the Windows Azure store, create a free New Relic addon
3. Configure an Web Site to use that addon
4. Open up the web project you want to monitor in Visual Studio
5. Install-Package NewRelic.Azure.WebSites
6. Enter the license key either as prompted, or manually in newrelic\newrelic.config
7. Publish to your Web Site
8. Browse around the site, then show the basic stats in New Relic's dashboard after waiting a few minutes

### Diagnostics
1. Enable all diagnostics settings under Configure under your choice of Azure Web Site in the Management Portal
2. Demonstrate application diagnostics using Warning / Error traces
3. Show site diagnostics by triggering a few exceptions or 404s
4. If time allows, demonstrate [Failed Request Tracing](http://www.iis.net/learn/troubleshoot/using-failed-request-tracing/troubleshooting-failed-requests-using-tracing-in-iis) and [Visual Studio Remote Debugging](http://blogs.msdn.com/b/webdev/archive/2013/11/05/remote-debugging-a-window-azure-web-site-with-visual-studio-2013.aspx)

### High Availability and Scaling
1. Demonstrate scaling up the number of instances by displaying the machine name on the site and increasing the number of instances.

