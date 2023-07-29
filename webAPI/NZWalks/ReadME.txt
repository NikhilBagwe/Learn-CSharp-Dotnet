This project manages the Walks and Trails of New Zealand

==> Execute below commands in sequence :

1. dotnet new webapi

2. dotnet build

3. dotnet run

4. dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 6.0.14

5. dotnet add package Microsoft.EntityFrameworkCore.Tools -v 6.0.14

6. dotnet ef migrations add "initial_migration"

7. dotnet ef database update








=> launchSettings.json : Stores launch related data of project.

=> appSettigns.json : Config file of project. Environment specific variables, default info. about project lies in this file.

=> Program.cs : Entry point of project. Code present inside it is executed first.
   Another important function of this file is to configure the HTTP Request Pipeline.
   By using Request pipeline we add Middleware which is a s/w that handles requests and responses.



===> DbContext class :

- DbContext class is part of EF core package.
- This class represents a session with the Database.
- Provides a set of APIs for performing DB operations.
- Responsible for maintaining a connection with DB, tracking changes to DB and performing DB operations.
- Also provides a way to define DB schema using Domain classes which maps directly to DB tables.
- DbContext class is like a bridge between Domain model classes and DB.


===> DbSets :

- DbSet is a property of DbContext class.
- It represents a collection of entities in the DB.


===> Connection String :

- If we don't have created our DB manually, we can just mention the name of our new DB to be made in our Connection string and EF will create it for us.


===> Dependency Injection :

- It is a design pattern used to increase the maintainability and testability of applications by reducing the coupling between components.
- Built in to ASP.NET core.
- USed to manage dependencies of services used throughout the application.
- At it's core DI works on this fundamental that instead of instantiating objects within a class, those objects are passed as parameters to the class(eg: like passing it to the constructor or method).
- This allows for greater flexibility in the way objects are created and managed as well as easier testing of individual components.
- The DI container is responsible for creating and managing instances of services which are registered within the container when the application starts.


===> Migrations :

- Migration cmd will gather all the information we have in DbContext and the connection string and create C# classes which on running the C# file will create tables in DB.




===> DTOs : Data Transfer Objects

- They are objects used to transfer data between different layers of components of an application.
- DTOs are subset of Domain models.
- They are simple objects that typically contain a subset of the properties of a domain object.
- Used for a specific purpose such as transferring data over the network or between layers of an application.
- We do mapping between DTO and domain model and DTO is sent back to the client when client requests data and Vice versa.
  So the overview of application is like this :
	Client <=> | DTO : API : Domain Model | <=> DB
- So instead of exposing the Domain models to the API view layer we expose DTOs.

==> Advantages of DTO :

1. Separation of concerns : Domain model is tightly coupled with DB schema whereas DTOs can be designed to match business requirements.

2. Performance : Retrieves only required data.

3. Security : Limits the amount of data that is exposed to client.

4. Versioning : Can be versioned independently thus, allowing you to update the API w/o breaking it.



==> [FromBody] : Used in post method, since we receive a body from the client.



{
  "name": "Mountain Walk",
  "description": "near hills",
  "lengthInKm": 12,
  "walkImageUrl": "some-img-url",
  "difficultyId": "65930786-CC8C-4816-6E92-08DB9000839C",
  "regionId": "6181D24F-51AE-423B-1D6F-08DB8FEC3D1D"
}


==> FOREIGN KEY VALIDATION :

- If we delete the parent record, automatically all related child records are deleted.
- To avoid this we can use 'OnModelCreating' in DbContext.
- We can set the .OnDelete() prop to throw exception.

