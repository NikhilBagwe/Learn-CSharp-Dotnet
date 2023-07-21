## Entity Framework :

- Entity Framework is an object-relational mapper (ORM) that enables .NET developers to work with a DB using .NET objects.
- ORM : Creates a "bridge" between object-oriented programs and, in most cases, relational databases. Put another way, you can see the ORM as the layer that connects OOP to relational databases.
- EF fits in the Data Layer which is present between the Business Layer (Business entities/domain classes) and the database.
- It saves data stored in the properties of business entities and also retrieves data from the database and converts it to business entities objects automatically.

### Features of EF :

1. Cross-platform framework
2. Allows us to use LINQ queries to retrieve data from the underlying DB.
3. Caching : EF includes first level of caching out of the box. So, repeated querying will return data from the cache instead of hitting the database.
4. Migrations: EF provides a set of migration commands that can be executed on the NuGet Package Manager Console or the Command Line Interface to create or manage underlying database Schema.

### Versions of EF :

- Microsoft introduced Entity Framework in 2008 with .NET Framework 3.5.
- Currently, there are two latest versions of Entity Framework: EF 6 and EF Core.
- EF 6 works only on Windows and "EF 6 core" is cross platform.

## Connection String :

- First connect the DB in Visual studio using "SQL Server Object Explorer".
- Once connected, view it's properties and there you can find the Connection string property.
- Add the constring in appsettings.json :

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=NUCDBSRVNUCDB2014;Integrated Security=False;User ID=sa;Password=nuc1234$; Initial Catalog=Nikhil;Encrypt=False;TrustServerCertificate=False"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

## Install EF core :

- Run cmd : dotnet add package Microsoft.EntityFrameworkCore.SqlServer

## Data Context :

- Data Context is something that brings in all of the information and allows us to manipulate it.
- It's going to tie all the DB tables together and gives a thing called "Context" where we can quickly access all of the tables.
- So create a "Data" folder and create a file inside it "DataContext.cs".
- "base" is something that will shove all the data received from outside class up into the DBContext.
- Next we are going to tell the DbContext what all our tables/models are.











98
