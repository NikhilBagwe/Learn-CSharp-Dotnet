## Intro :

- In order to acheive the Cross Language Common IL code, there are 2 important concepts in .NET framework:
- Common Type system - CTS
- Common Language Specification - CLS.

## CTS : 

- CTS is the big thing and CLS belongs to it.
- Suppose if we create 2 separate projects. One uses C# and other uses VB.Net
- We define an variable of type integer in both them and compile the code.
- If you check the DLL code of both of them, the integer is defined as "int32" in both the DLL i.e in same syntax.
- So even at the time of defining the variable, it was declared in diff. syntax as per the language at EOD .NET compiles an Integer to int32 - common type system i.e Common data type
