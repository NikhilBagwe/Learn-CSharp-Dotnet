## Steps :

1. Create the required tables in DB.
2. Add CORS policy in Program.cs
3. Scaffold DB context using below command. Also we need to install all 3 entity framework core packages - SqlServer, Tools, Design for scaffolding to work.

```js
dotnet ef dbcontext scaffold "server=192.168.11.130\nucdb2014;database=Nikhil;user id=sa;password=nuc1234$" Microsoft.EntityFrameworkCore.SqlServer --context-dir Data --output-dir Data
```

4. Above command generates DbContext and Models in "Data" folder. It generates models for all tables present in that DB.
5. Then we have to generate the API controller for the Models (Entity class).
6. The normal controller code which we can generate in Visual Studio IDE has certain downsides - We should not use our Entity class to fetch the data in our api endpoints. The Entity class must only interact with DB.
