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








