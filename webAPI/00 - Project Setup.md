## Setup :

1. Run cmd : "dotnet new webapi" to create "ASP.Net Core WebApi" project.
2. Then run : "dotnet run"
3. Sometimes it might throw error : error NU1100: Unable to resolve 'Swashbuckle.AspNetCore (>= 6.2.3)' for 'net6.0'.
4. So run cmd : "dotnet nuget add source --name nuget.org https://api.nuget.org/v3/index.json" - Then build project.
5. Go to url to open swagger : https://localhost:7101/swagger/index.html
