## Commands :

### 1. dotnet new mvc

### 2. dotnet tool install --global dotnet-aspnet-codegenerator --version 6.0.0

### 3. dotnet add package Microsoft.EntityFrameworkCore -v 6.0.14

### 4. dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 6.0.14

### 5. dotnet add package Microsoft.EntityFrameworkCore.Tools -v 6.0.14

### 6. dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.14

### 7. dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6.0.0

### 8. Generates Views, Controller, DbContext : dotnet aspnet-codegenerator controller -name MoviesController -m Movie -dc demo.Data.MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

### 9. Get help regarding aspnet-codegenerator : dotnet aspnet-codegenerator controller -h

### 10. Migration : dotnet ef migrations add InitialCreate, dotnet ef database update


## Project file: 

```html
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.14" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.14">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.14" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.14">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.0" />
  </ItemGroup>

</Project>

```
