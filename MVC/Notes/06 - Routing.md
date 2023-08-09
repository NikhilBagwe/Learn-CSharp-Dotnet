## Routing :

- It is a mechanism in ASP.NET MVC in which it will inspect the incoming requests i.e URLs amd then map that requests to respective controllers aand their Action methods.
- Routing is implemented in Program.cs file. It is added as a middleware in the request processing pipeline.
- Routing = URL + HTTP methods
- Mapping - The received URL is mapped with the Action method of respective Controller.

## Flow :

1. User enters a certain URL in browser i.e Client.
2. At first, the request goes to Routing mechanism. It directly dosen't go to Controller.
3. Routing mechanism will check which controller needs to be called as per the routes are configured in app.
4. Then accordingly an Action method will be called and the it's Result will be returned as Response to the browser.

---

## Types of Routing :

1. Convention based Routing - Used in Normal web application.
2. Attribute based Routing - Used where concept of API is used in web app.
