# WorkoutApiFsd


# Stack

.NET Framework: 4.5.2  
WebAPI: 2.2  
Entity Framework: 6.2.0  
Microsoft.VisualStudio.QualityTools.UnitTestFramework: 15.0.2  
Moq: 4.8  
GIT client: 2.10.2  
Jenkins: 2.114  
Web Deploy 3.6  
IIS: 10.0.16299.15  

## Development server

Open the solution FSD.WorkoutTracker.sln. Select FSD.WorkoutTracker web project and Click `Ctrl + Shift + D` to start a new instance of the application in IISExpress. Navigate to `http://localhost:53607/` in a browser. The app will be loaded in the browser.

## Build

Click `Ctrl + Shift + B` to build the project. The build artifacts will be stored in the `bin` directory. Use the publish profile 'CustomProfile' to build the application in Release mode and deploy the build to IIS through Web Deploy.

## Jenkins

Run `git push` to push the staged changes to remote repository. Jenkins will poll GIT SCM every 5 minutes to pull out the latest changes(if any), trigger a build and host the latest changes through Web Deploy in IIS.

Job url: `http://localhost:8080/job/WorkoutTrackerAPI/`

## Production server

Navigate to `http://localhost:8888/Help` in a browser to verify the WebAPI endpoints are up and running in IIS.

## Running unit tests

Click 'Run All' in Test Explorer of Visual Studio to execute the unit tests VSTest test runner.  
Unit tests added: 11/11 tests

## Git

Version control management software used is GIT with a master branch and a feature development branch. When a feature is complete, the feature branch is merged back to the master.

Master branch GIT URL: http://172.18.2.18/abrahamrohithroy/workout-api-fsd/tree/master  
Feature branch GIT URL: http://172.18.2.18/abrahamrohithroy/workout-api-fsd/tree/feature_branch_1  