## Steps :

1. Create the required tables in DB.
2. Add CORS policy in Program.cs
3. Scaffold DB context using below command. Also we need to install all 3 entity framework core packages - SqlServer, Tools, Design for scaffolding to work.

```js
dotnet ef dbcontext scaffold "server=192.168.11.130\nucdb2014;database=Nikhil;user id=sa;password=nuc1234$" Microsoft.EntityFrameworkCore.SqlServer --context-dir Data --output-dir Data
```

4. Above command generates DbContext and Models in "Data" folder.
