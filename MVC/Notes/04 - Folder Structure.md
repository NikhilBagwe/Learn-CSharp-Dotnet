## Folder Structure :

### As per Visual Studio project :

1. Connected Services : We add the Services that our project is using.
2. Dependencies : Project dependencies. It has 2 folders in it : Analyzers - Rest of the dependencies such as MVC, Razor, etc. and Frameworks - It has files for ASP.NET Core, EntityCore, etc.
3. Properties -> launchSettings.json : Settings to be done/set in order to run app on local/development machine. launchSettings.json file is used only within Local Development machine i.e this file is not required while pushing app to PROD server. Kestrel Web server
4. wwwroot - Used to store static files. Eg: images, bootstrap files, global css, js files
