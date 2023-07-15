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
- A class library dosen't have a UI. It contains pure business logic.
- Now if you explore SomeCommonlogic class library in explorer, you will only find a DLL of it, no .exe file.

## Class Library :

- It is used to share common logic without the UI across across the projects in a solution.
- The output of a class library is DLL which at EOD is an Assembly.

## NOTE : List out all templates installed on computer : dotnet new --list

- Now if I have to use "SomeCommonlogic" inside the Console application "ProjectConsole" : Right click on Dependencies ->  Add reference -> Select "SomeCommonlogic"
- BTS in ".csproj" file, the class library gets linked to the project inside <ItemGroup> tag as Reference.
- Now go to ProjectConsole .cs file -> Include "SomeCommonlogic" using "using" keyword.
- Create object of it and use it.

## Assemblies :

- Assembly means the final unit of deployment.
- The final deployables that you give to the end user for deployment are termed as Assemblies.
- A DLL is an assembly, .exe is an assembly, class library is an assembly.


## Q. When we build C# code, why do we have 2 folders, "bin" and "obj" ?

- Every file is compiled separately in "obj" folder. Suppose project has 10 c# files, than their compiled version is stored separately in obj folder.
- Finally all compiled files are gathered together, compiled and the final assembly is stored in the "bin" folder.














5
