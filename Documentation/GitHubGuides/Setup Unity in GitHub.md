**Setting up a Unity Project in GitHUb**
* Log into your GitHub account
* Select Repositories Tab
    * Click New
    * ![New Repo Button](./Imgs/New%20Repo%20Button.png)
    * Give Repo a Name, Make sure its public, and select a Unity .gitignore file then click Create Repository.
    * ![Naming Repo and adding Git Ignore](./Imgs/Naming%20Repo%20and%20adding%20Git%20Ignore.png)
    * Your Repository is created, so we now **Clone** this repository to our PC, So press Code button then Copy URL to clipboard and minimise browser 
    * ![Copy URL for cloning](./Imgs/Copy%20URL%20for%20cloning.png)
    * On Desktop, or in an appropriate place on your PC through File Explorer, Right Click>Select More Options>GitGUI Here
    * Select Clone existing repository
    * ![GitGUI Initial options](./Imgs/GitGUI%20Initial%20options.png)
    * Paste copied URL into Source Location and Click Browse for Target Destination
    * ![Locations Source and Destination for Repo Cloning](./Imgs/Locations%20Source%20and%20Destination%20for%20Repo%20Cloning.png)
    * This will default to the location you Right Clicked on above, click Select Folder
    * ![Destination Location](./Imgs/Destination%20Location.png)
    * It is important to ADD a folder name which does not already exist where the Repo will be placed
    * ![Destination FolderName](./Imgs/Destination%20FolderName.png)
    * Click Clone
    * The default GitGUI display is shown
    * ![Start GitGUI](./Imgs/Start%20GitGUI.png)
    * We minimise this to return to it later
    * We should now see a new Folder at our location
    * We now do work on the the local repo.
    * You could create a new Unity project directly in the folder or..
    * If you already have a UNity project created then you can CUT and paste into repo folder. It is important that you CUT instead of copy.
    * ![Unity Folder in Repo Folder](./Imgs/Unity%20Folder%20in%20Repo%20Folder.png)
    * Before we commit, we need to move the .gitignore into the unity folder
    * ![Move to Unity folder](./Imgs/Move%20to%20Unity%20folder.png)
    * ![.gitignore moved](./Imgs/.gitignore%20moved.png)
    * Maximise or reopen GitGui and rescan if necessary
    * ![New Files in GitGui](./Imgs/New%20Files%20in%20GitGui.png)
    * You should see a reasonable number of files (less than 100) in the unstaged changes area
    * ![Final steps to first Push](./Imgs/Final%20steps%20to%20first%20Push.png)
    * Work your way done through these buttons, Add a commit message and finally push to GitHub
    * You should hopefully get a successfull push message,
    * ![Success Push](./Imgs/Success%20Push.png)
    * You may be asked to sign into GitHub account on first time, choose sign in through browser
    * Go back to the repository on a browser, usually you will see, if not skip to alternative.
    * ![Recent push notification](./Imgs/Recent%20push%20notification.png)
    * Click Compare and pull request
    * Then Create Pull Request
    * Then Merge Pull Request
    * Then Delete branch
    * ALTERNATIVE
    * Sometimes there is no notification, but you can see if there is another new branch
    * ![Two branches](./Imgs/Two%20branches.png)
    * Check to see if the master has changes you just pushed.
    * Click Pull Requests and New Pull Request
    * ![Manual Pull Request](./Imgs/Manual%20Pull%20Request.png)
    * Make sure you are merging master into main, then create and merge as above and delete the branch
    * Check that your changes are now in your repo