## Dependency Injection :

- Instead of creating a new instance of class whenever we want it, we can just put into DI and just ask for the instance of class.
- Tight Coupling means when a class is dependent on another class, then it is said to be a tight coupling between these two classes.
- In that case, if we change the Dependent Object, then we also need to change the classes where this dependent object is being used.
- Loosely Coupling means two objects are independent of each other.
- The loosely coupled nature allows us to manage future changes easily and also allows us to manage the complexity of the application.
- The Dependency Injection Design Pattern in C# is a process in which we are injecting the dependent object of a class into a class that depends on that object.
- DI is used to implement IoC - Inversion of Control

## Working :

- DI allows creation of creation of dependency objects outside of a class and provides those objects to a class that depends on it in three different ways (i.e. using Constructor, Method, and Property).
- DI design pattern invovles 2 types of classes :

### Client class :
- The Client Class (dependent class) is a class that depends on the Service Class.
- It wants to use the Services (Methods) of the Service Class.

### Service class :
- The Service Class (dependency) is a class that provides the actual services to the client class.

### Injector Class :
- The Injector Class is a class that injects the Service Class object into the Client Class.

## Constructor Injection :

- When the Injector Injects the Dependency Object (i.e. Service Object) into the Client Class through the Client Class Constructor, then it is called Constructor Dependency Injection.

---
---

## A more simpler explantion :

1. The literal meaning of DI is to inject dependencies.
2. A Dependency is just another Object that your class needs to function
3. DI means that the dependency is pushed into the class from the outside. It means that we shouldn't instantinate the dependencies using "new" operator from inside the class.



















