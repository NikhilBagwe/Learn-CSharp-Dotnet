## Middleware :

- Middlewares are simple functions/methods having some logic which needs to be executed when client sents a request to Server.
- Eg: User requests a page which requires Authorization. Middleware is used to handle it.
- Your request will go through Middleware while going from Client to Server and when Server responds
- HTTP Request Pipeline - The request sent from Client side goes through HTTP Request Pipeline to Web App server.
- Middlewares are present in the pipeline.
- Then the response sent by the server again goes through the pipeline(middleware) and reaches Client side.

## Middleware in ASP.NET :

- In ASP.NET, a middleware is a component(class) which is executed on every request.
- It controls how our application responds to HTTP requests.
- Middleware are software components that are assembled into Application Pipeline i.e "Program.cs" file to handle requests and responses.
- It can also contorl how our application look when there is an error. Like which page needs to be displayed, etc.
- Plays an important role in authenticating a User to perform certain actions.
- Each piece of middleware in ASP.NET is an object and each piece has a very specific, focused and limited role.

## NOTE :

- Order in which Middleware is written is important.
- As they will be executed as per that order.

## Example :

### Basic :

```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

// Custom Middleware inside Run() - Whatever request will come to server, it will send below message in response.
// https://localhost:7226/anything
// Thus for each and every request, this middleware will be executed.
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Welcome to asp.net");
});

// Will never be executed.
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello world");
});

// Server starts at this line. Our app is hosted onto server. So writing this is im[portant.
app.Run();

```

- Run() method dosen't execute middlewares after it (i.e subsequent middlewares). The concept of 'next' is used in such case.
- If you want to use multiple middlewares in your app than use "app.Use()".

 ### app.Use() :

 - If we want to execute multiple middlewares than don't use "Run()" as it only takes "context" as parameter.
   
```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("1st Middleware \n");
    // passing request to next middleware
    await next();
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("2nd Middleware \n");
    // passing request to next middleware
    await next();
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello world");
});

// Server starts at this line. Our app is hosted onto server. So writing this is important.
app.Run();

```














