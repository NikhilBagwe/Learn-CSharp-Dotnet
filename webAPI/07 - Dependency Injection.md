## Why use DI ?

- When you create a Service in an Asp.net project, the question is how will you make use of that service in every Controller ?
- Thus, we use DI for the same purpose.

## Steps to add DI :

1. Create an Folder called Services.
2. Create an Interface inside it.
3. Create a Class that implements the interface.
4. Register it as a Service in "Program.cs" right above the line where the application is build. We use AddScoped method which creates a new instance of the service for each HTTP request. 
5. Now you can use Constructor to inject the Service in any Controller.
