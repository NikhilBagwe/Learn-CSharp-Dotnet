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

- We can also do it manually but at times when a model has many properties it will become a problem.

```csharp
public async Task<ActionResult<AuthorCreateDto>> PostAuthor(AuthorCreateDto authorDto)
{
    // Since our DB stores data in format of Author model we have map the "authorDto" that user gives to author object.
    var author = new Author
    {
        Bio = authorDto.Bio,
        FirstName = authorDto.FirstName,
        LastName = authorDto.LastName
    };

    // Above process is viable when there are less properties in a Model. But in case of models having multiple props. we have to use Automapper library.

    await _context.Authors.AddAsync(author);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetAuthor), new { id = author.Id }, author);
}
```

- Install Automapper package.

```html
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.0
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

- Now using DI we can use Mapper in our controller.

```csharp
public async Task<ActionResult<AuthorCreateDto>> PostAuthor(AuthorCreateDto authorDto)
{
    var author = _mapper.Map<Author>(authorDto);

    await _context.Authors.AddAsync(author);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetAuthor), new { id = author.Id }, author);
}
```















