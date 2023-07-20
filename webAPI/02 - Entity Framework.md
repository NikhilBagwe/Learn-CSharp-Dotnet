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
