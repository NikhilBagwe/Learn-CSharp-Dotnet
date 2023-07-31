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
3. DI means that the dependency is pushed into the class from the outside. It means that we shouldn't instantinate the dependencies using the "new" operator from inside of the class.
4. Instead we take it as a Constructor parameter.

## Example : 

- A House building robot is programmed to build walls of the house using raw materials.
- One of the walls has a door to be built.
- So will you program the robot to "build a new door from scratch using raw materials" or "use a Ready-made door and simply install it" ?
- Of course, just simply use a Ready made door.
- That's what DI does. It decouples your classes construction from the construction of it's dependencies.

## Dependency Inversion principle :

- The principal states that code should depend on Abstractions (Interfaces).
- Thus, by depending on abstractions we are decoupling our implementations from each other.

## Problem !

- After adopting DI, now each of our classes require some of these dependencies to function.
- Now for each class we have to figure out which dependency they need also how to instantiate them.

## Solution : Dependency Injection Container

- At root of Dependency Injection Container is nothing more than a map of dependencies your Class needs with the logic to create those dependencies if they are not been created. 



















