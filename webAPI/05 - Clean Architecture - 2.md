### [Youtube link](https://www.youtube.com/watch?v=NzcZcim9tp8)

---

## Layered Architecture (LA) :

- It consists of 3 layers in following order : Presentation, Application (or Business Layer) and Data Access Layer.
- App layer - Contains the process and domain logic.
- Presentation layer - Sort of entry point to our application. In context of backend it is something like web apis.
- Pretty simple architecture.

## Disadvantages of LA : 

- It follows a data centric approach. First you have to write the code for Data access layer as the remaining layers are dependent on it.
- Dosen't follow Dependency Inversion principle (high level modules should not import anything from low level modules. Both should depend on abstraction). So in case of LA, application layer depends on Data access layer which is low level.

---

## Clean Architecture :

- In CA, the flow of dependency is inwards.
- Following are the layers starting from the center layer.
  
### 1. Domain layer :
- Has no dependencies.
- Contain a lot of pure functions.
- No I/O operations are performed.
- OOP is followed.

### 2. Application layer :
- Contain Domain logic.
- Here we will incorporate CQRS.

### 3. Infrastructure layer :
- Contain data access layer, logging, monitoring, etc.

### 4. Presentation layer :
- Contain Web API code.
- Entry point into our system.

---
---

## What is domain in CA ?

- It is basically contains the core logic which will be same throughout the whole system we are building.
- This is where you define your domain entities, value objects, business logic, and domain-specific rules.
- It is INDEPENDENT.
- Example : Create a class library "CleanMovie.Domain". Then create a "Movie.cs" class and add below code in it.

```csharp
namespace CleanMovie.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Cost { get; set; }
    }
}
```

## Application layer :

- It dictates how the business logic of the application should be and it only depends on Domain Layer.
- Defines and implements use cases or application-specific business operations.
- Acts as an intermediary between the outer layers (such as the user interface and infrastructure) and the domain layer. 
- For example, we can create a Repository in this layer which will concerned with the Data access. We will create an Interface of it here but won't implement it here.
- Interface don't have any methods nor access modifiers.
- Service is responsible for defining the use case. Thus we have Interface and a class implementing that interface.

## Infrastructure Layer :

- Here we are going to perform the actual operations like talking to the DB, APIs, etc. basically anything external to our Domain.
- Infrastructure depends on Application so add a refernece to it.
- For example, we can implement our Repositories here.










