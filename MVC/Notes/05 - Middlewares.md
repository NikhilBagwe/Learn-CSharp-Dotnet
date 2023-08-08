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
