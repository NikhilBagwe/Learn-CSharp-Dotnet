## MVC :

- The Model-View-Controller (MVC) is an architectural pattern which separates an application into three main groups of components: Models, Views, and Controllers.
- Models - Contains classes that represent Business Entities.
- View - Presentation Logic i.e HTML pages and UI
- Controller - Business Logic i.e Main Logic of our application. Like how to take data from Model and then pass it to View. Acts as a bridge between Model and View. It is the backbone of MVC.
- Separation of concerns is present i.e DB related work is done through Models, Logic Work in Controller, etc.
- MVC is not a Framework but a Design Pattern. ASP.NET Core is the Framework.
- When we design an application, we first create the Architecture of the app and thus, MVC plays an important role at this stage.

## Advantages of SoC (Separation of Concerns) :

1. Allows to work on individual pieces of system in isolation.
2. Facilitates resusability.
3. Ensures maintainability of system
4. Ensures extensibility of app - like insert new piece of code into app easily.

## MVC Working :

![img_2](https://github.com/NikhilBagwe/Learn-CSharp-Dotnet/assets/67143015/db8df31a-77aa-4a98-bc9a-3e875fb05e7a)

- User is the one who uses our application.
- When user hits the url request. the request first goes to controller.
- Then controller checks if any data is present inside Model (Model takes data from DB).
- If data is present in Model than the View is updated with the data. It is job of controller to take data from Model and render it onto View.
- Then User sees the updated View.
- In case when no data is present in Model i.e it is an Static application, then Controller directly renders the View to User.























