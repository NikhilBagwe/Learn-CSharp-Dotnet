## How normally a data-driven application access data from a database?

- We write all the data-access related code in the main application itself.
- Lets say we have an Employee Controller which contains Action methods to perform CRUD operations.
- Further the Controller's Action methods, use Entity Framework to generate and execute the queries and retrieve data from DB.
- Thus, the EF in turn interacts with the underlying DB.

## Drawbacks of the Above Implementation :
