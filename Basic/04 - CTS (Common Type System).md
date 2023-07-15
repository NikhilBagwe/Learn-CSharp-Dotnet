## Intro :

- In order to acheive the Cross Language Common IL code, there are 2 important concepts in .NET framework:
- Common Type system - CTS
- Common Language Specification - CLS.

## CTS : 

- CTS means Common data type is defined for all languages.
- CTS is the big thing and CLS belongs to it.
- Suppose if we create 2 separate projects. One uses C# and other uses VB.Net
- We define an variable of type integer in both them and compile the code.
- If you check the DLL code of both of them, the integer is defined as "int32" in both the DLL (IL code) i.e in same syntax.
- So even at the time of defining the variable, it was declared in diff. syntax as per the language(C# or VB) at EOD .NET compiles an Integer to "int32" - common type system i.e Common data type.
- So there is a CTS when these languages get compiled to IL code.

## CLS :

- They are the guidelines or rules that says how computer programs can be turned into Common Intermediate Language (CIL) code.
- Thus, if the diff. components written in diff. languages follow the rules of CLS, they come on a common ground and they become interoperable.
- CLS is part of CTS.

## Notes : CTS defines the common data types and CLS sets down some rules which must be followed to have cross compatibility.
