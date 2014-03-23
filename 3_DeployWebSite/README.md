Global Windows Azure Bootcamp Perth 2014
========================================

This is a hands-on lab for deploying a Windows Azure Web Site.

1. Download and install the [Windows Azure command-line tools for Windows](http://go.microsoft.com/?linkid=9828653&clcid=0x409) (found via the [Windows Azure downloads page](http://www.windowsazure.com/en-us/downloads/)).
    * The documentation for the command-line tools is at [http://www.windowsazure.com/en-us/documentation/articles/xplat-cli/](http://www.windowsazure.com/en-us/documentation/articles/xplat-cli/) - feel free to read it to get more detailed explanations of the below steps
2. Open a **new** command window and execute `azure` to see an overview of the commands you can run
    * If it complains that it can't find `azure` then your `PATH` variable wasn't updated and you need to open `Windows Explorer` right-click on `Computer` and select `Properties` and then click on the `Environment Variables` button and click `OK` and `OK` again.



Advanced: Create a site using the command-line tools
---------------------------------------------------------
1. Download your `.publishsettings` file that contains the credentials for your Windows Azure account to perform API requests by executing `azure account download` in the command line, which will open a browser window and require you to log into your  Azure account
2. Find the location of the downloaded `.publishsettings` file
3. Import the `.publishsettings` file into the Azure commandline by using `azure account import {path to .publishsettings file}`
    * Delete the downloaded `.publishsettings` file
    * If you have production instances on your subscription then read the documentation to find out where it stores the settings and how to encrypt the directory it's in
5. Find out all the locations that you can deploy to with `azure site location list`
6. Create a new website using `azure site create "<your_unique_site_name>" --location "A Valid Location"`
    * You can also leave out the `--location` option and it will prompt you for the location to deploy to
7. View the site status using `azure site list` or by looking in the portal at your Web Sites
8. The command-line tools are very discoverable - you can navigate the possible list of commands by executing `azure` and seeing the list of command categories and then `azure [category]` to see the list of commands for a given category then to see the options for a particular command execute `azure [category] [command] -h`
    * Feel free to play around and see all of the options that are available to you

Advanced: Use git for publishing
----------------------------------
This requires you to have Git set up on your machine.

1. Go to the Dashboard of a Web Site in the Windows Azure portal
2. Click on the `Reset your deployment credentials link` and create some credentials
    * These credentials are used for FTP and Git
    * Make sure you remember the password as you will need it later
3.  Pull up the command-line and in a new directory somewhere execute `azure site create "<your_unique_site_name>" --location "A Valid Location" --git`
    * This will create a site and set up a git checkout in the current directory with a remote called `azure` that allows you to push from the current checkout to your azure site
    * If you are feeling particularly adventurous then type in `azure site create -h` and use the GitHub options instead to link the site to a GitHub repository
        * Leave out the password option to make it prompt you so you don't have to type it in clear text
4. Put some files in the repository that has been created and commit them then do an `git push azure` to deploy the changes to Azure
    * It will prompt you for the deployment credential password you set up in step 2
    * If you connected GitHub then you will need to push the changes to your GitHub repository and it will automatically deploy
5. To navigate to your site execute `azure site browser "<your_site_name>"`
