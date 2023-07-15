## Understanding Basic code Structure :

- In a basic C# code, at the top you have a namespace.
- Then you might have one or more classes inside a namespace.
- Then inside class you can have one or many functions/methods.
- Inside the function you write the actual code logic.

```csharp
using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("hello, World!");
            Console.WriteLine("hi");
        }
    }
}
```

- The scope of a class is defined by the curly brackets.

## Main function :

- Main function is the entry point of our application.
- An application can have only one "Main" function. It will throw error if we have two Main functions.


## Executable and DLL :

- Suppose if we have 2 projects - a web application and console application.
- They both have different UIs but share some common business logic.
- It is a bit difficult to do that because projects are self-executable i.e inside their bin folder a ".exe" file is present.
- Thus we use DLL.
- A DLL does not execute by itself.
- DLL can be used inside web, console, desktop applications.
- To create a DLL : Right click on solution -> Add -> New Project -> Class Library(.NET core) -> SomeCommonlogic (name of class library).
- A class library dosen't have a UI.
- Now if you explore SomeCommonlogic class library in explorer, you will only find a DLL of it, no .exe file.

## NOTE : List out all templates installed on computer : dotnet new --list

- Now if I have to use "SomeCommonlogic" inside the Console application "ProjectConsole" : Right click on Dependencies ->  Add reference -> Select "SomeCommonlogic"
- BTS in ".csproj" file, the class library gets linked to the project inside <ItemGroup> tag as Reference.
- Now go to ProjectConsole .cs file -> Include "SomeCommonlogic" using "using" keyword.
- Create object of it and use it.





















5
