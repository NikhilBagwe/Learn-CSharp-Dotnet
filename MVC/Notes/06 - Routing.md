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

---

## Convention Based Routing :

### Ready made routing available in Asp.net core mvc app :

```csharp
// Program.cs - 

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
```
- The above route gets the Home controller and calls Index() method in it which returns a View().

### Adding Routing from scratch in Asp.net Empty project :

1. Create empty project.
2. Make Controller folder and add a controller named "Homecontroller" to it.
3. The Homecontroller must be returning a View() from Index method which is not created yet.
4. So create Views -> Home -> Index.cshtml file
5. Now all views added in Homecontroller will be made inside Home folder.














