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

## Mapping a DTO to Original Model while saving in DB :

- Install Automapper package.

```html
dotnet add package AutoMapper --version 12.0.0
```
- Create a new Folder "Configurations" containing the MapperConfig.cs file and add the mapping logic in it.

```csharp
using AutoMapper;
using BookStoreAPI.Data;
using BookStoreAPI.Models.Author;

namespace BookStoreAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
        }
    }
}
```
- Add the config file to Program.cs as a Service.

```csharp
builder.Services.AddAutoMapper(typeof(MapperConfig));
```














