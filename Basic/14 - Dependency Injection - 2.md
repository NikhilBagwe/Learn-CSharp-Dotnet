## Tight Coupling :

- Tight Coupling is when a group of classes are highly dependent on each other.
- For example, there are 3 classes - A, B and C.
- When we want to create the obj of class A, class A creates obj of Class B and C in it.
- Thus, we cannot create an obj of class A if anyone of class B and C are not available.
- Making any change in class B and C will have effect on A.
- Thus, class A is highly dependent on class B and C.
- Tight Coupling should be avoided in while building application.

## Disadvantages of Tight Coupling :

- The responsibilities/functionalities are shared across multiple classes instead of having just one class.
- Difficult to maintain.
- Difficult to test.

## Loose Coupling :

- Loose Coupling means that classes are independent of each other.
- Another definition would be that there is as less as possible dependency present between classes.

## Advantages of Loose Coupling :

- It is a design that promotes single-responsibility and separation of concerns i.e a class is not dependent on any other class.
- Easy to maintain.
- Easy to test.

---

## How to avoid Tightly coupled state ? 

- Answer is to Use Dependency Injection.
- DI is acheived using Interfaces.
- Interfaces are a powerful tool to use for decoupling (converting tight to loose coupling).
- In DI, classes communicate with each other using Interfaces rather than Concrete classes (a class that has an implementation for all of its methods).

## Dependency Injection :

- DI is a software pattern.
- DI is basically providing the objects that an object needs instead of having it construct the objects themselves.














