[Blog Link](https://dotnettutorials.net/lesson/repository-design-pattern-csharp/)

## How normally a data-driven application access data from a database?

- Most data-driven applications need to access the data residing in one or more other data sources i.e. in the databases.
- We write all the data-access related code in the main application itself.
- Lets say we have an Employee Controller which contains Action methods to perform CRUD operations.
- Further the Controller's Action methods, use Entity Framework to generate and execute the queries and retrieve data from DB.
- Thus, the EF in turn interacts with the underlying DB.

## Drawbacks of the Above Implementation :

- The drawback is that the database-access code is embedded directly inside the controller action methods.
- This can lead to Code duplication.
- We need to change the controller even if we do a small change in the data access logic.
- For example, if the application is modifying the employee information from two controllers, then each controller will repeat the same data access code. And future modifications also need to be done at two places i.e. the two controllers where we write the same data access code.

---

## Repository Pattern :

- It acts as a middle layer between the rest of the application and the data access logic.
- That means a repository pattern isolates all the data access codes from the rest of the application.
- The advantage of doing so is that, if you need to do any changes then you need to do it in one place.

### What is Repository?

- A repository is nothing but a class defined for an entity, with all the possible DB operations. 
- For example, a repository for an Employee entity will have the basic CRUD operations and any other possible operations related to the Employee entity.

### Why do we need the Repository Design Pattern in C# ?

- To acheive separation between the actual database, queries, and other data access logic from the rest of the application.
- Repository Design Pattern is used to create an abstraction layer between the data access layer and the business logic layer of the application.
- In our example, we need to separate the data access logic from the Employee Controller. 

---

### Conclusion :

- RP minimizes duplicate query logic.
- Decouples your applcation from Persistence frameworks i.e EF (A persistence framework is middleware that assists in the storage and retrieval of information between applications and databases). Meaning we can change our ORM anytime.

---
---

[YT Video](https://www.youtube.com/watch?v=x6C20zhZHw8)

## What is RP ?

- A collection of classes focused on encapsulating the logic necessary to interact with our data with following benefits:
  
1. Centralize common data access functionality.
2. Better code maintainability.
3. Decoupling Controllers from Infrastructure layer used to fetch data.


### Non-Generic Repository :

- In this case, we need to create a separate repository for each entity of our application.
- For example, if we have two entities, Employee, and Customer in our application, then we need to create two repositories.
- Employee Repository will have operations related to Employee Entity and Customer Repository will have operations related to Customer Entity only.

### Generic Repository (One Repository for All Entities) :

- A Generic Repository is one that can be used for all entities.
- In other words, the Generic Repository can be either used for Employee Entity, Customer Entity, or any other entity. 




















