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
