## Folder Structure :

### As per Visual Studio project :

1. Connected Services : We add the Services that our project is using.
2. Dependencies : Project dependencies. It has 2 folders in it : Analyzers - Rest of the dependencies such as MVC, Razor, etc. and Frameworks - It has files for ASP.NET Core, EntityCore, etc.
3. Properties -> launchSettings.json : Settings to be done/set in order to run app on local/development machine. launchSettings.json file is used only within Local Development machine i.e this file is not required while pushing app to PROD server. Kestrel Web server
4. wwwroot - Used to store static files. Eg: images, bootstrap files, global css, js files
5. Controller - When our application runs for the first time, the "Index()" Action method present inside HomeController is called which returns a View. The View is defined in Views -> Home -> Index.cshtml
6. appsettings.json - It is similar to the web.config file present in previous versions of ASP.NET. We mention confuguration settings, DB connection strings, application scope global variables, etc in this file.
7. Program.cs - It is the first file which runs when we run the application. Multiple Middlewares are defined here.

## Middleware :

- It is nothing but a component(class) which is executed on every request in ASP.NET core app.
