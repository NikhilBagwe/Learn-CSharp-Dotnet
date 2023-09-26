## Intro : [Blog Link](https://betterprogramming.pub/the-clean-architecture-beginners-guide-e4b7058c1165)

- Clean Architecture also called as Onion Architecture.
- The core concept is that we have the Core logic/Domain in center of everything and the Infrastructure, Database and rest part of the application sits on the outside.
- Thus, we can easily replace the outer logic without changing the core logic.
- The Dependency Rule states that the source code dependencies can only point inwards.This means nothing in an inner circle can know anything at all about something in an outer circle. i.e. the inner circle shouldn’t depend on anything in the outer circle.
  
  ![img-1](https://github.com/NikhilBagwe/Learn-CSharp-Dotnet/assets/67143015/8e047c01-5c53-41e1-ae26-775e8e3a98fc)
  ![img-2](https://github.com/NikhilBagwe/Learn-CSharp-Dotnet/assets/67143015/65f3c3bd-b8f6-42ef-a0d2-37af347680b0)

## Steps:

1. Create a sln file: dotnet new sln -o BuberDinner
2. Go inside the generated project folder and create API. Cmd: dotnet new webapi -o BuberDinner.Api
3. Also create the Contracts folder. Cmd: dotnet new classlib -o BuberDinner.Contracts
4. Infrastructure folder: dotnet new classlib -o BuberDinner.Infrastructure
5. Application folder : dotnet new classlib -o BuberDinner.Application
6. Domain folder : dotnet new classlib -o BuberDinner.Domain
7. Add all projects to sln file: Cmd = dotnet sln add **/*.csproj (Works on Git bash only)
8. Reference projects with each other. Cmd : dotnet add .\BuberDinner.Api\ reference .\BuberDinner.Contracts\ .\BuberDinner.Application\
9. dotnet add .\BuberDinner.Infrastructure\ reference .\BuberDinner.Application\
10. Application dependency on Domain : Cmd = dotnet add .\BuberDinner.Application\ reference .\BuberDinner.Domain\
11. dotnet add .\BuberDinner.Api\ reference .\BuberDinner.Infrastructure\
12. Run a particular Project: cmd = dotnet run --project .\BuberDinner.Api\

### REST Client vscode extension: 

- View API response directly into VS code.
- Create a '.http' file inside which mention the request url and click on 'Send Request' present just above it to view response.

## Understanding the project :

- The PRESENTATION LAYER will act as a door to outside world. It will contain the APIs and Contracts.
- 



















