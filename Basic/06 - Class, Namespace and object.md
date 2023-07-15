## Class :

- It is a blueprint, a template.

```csharp
using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args){
            Maths a = new Maths(); // create an object
            a.printName();

            Console.WriteLine(a.Add(3,34));
        }

        class Maths
        {
            public string name = "Nikhil";
            
            public void printName()
            {
                Console.WriteLine(name);
            }

            public int Add(int num1, int num2)
            {
                return num1 + num2;
            }
        }
    }
}
```



## Namespace :

- Helps us to group classes together.

```csharp
using System;
using MathsNs; // import namespace

namespace Basic
{
    class Program
    {
        static void Main(string[] args){
            Maths a = new Maths();
            a.printName();

            Console.WriteLine(a.Add(3,34));
        }

        
    }
}

namespace MathsNs
{
    class Maths
    {
        public string name = "Nikhil";
        
        public void printName()
        {
            Console.WriteLine(name);
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    class AdvanceMaths
    {
        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
```

- Normally the above namespace MathsNs code is put into a separate class library file i.e create a separate DLL and reuse the code from there so it is better organised.
- You have to import the namespace into your file as we did above or use following syntax "MathsNs.Maths = ..."
- We can have namespace inside a namespace.

## Root namespace and Root Class of .NET :

- The "using System;" that we write at top of our code is the Root Namespace.
- All the classes of .NET framework belong to System namespace.
- Inside the System we have a class called as "Object" which is the ultimate base/root class of all .NET classes.
- So whenever you create a class in .NET it inherits from this Object class. It is also the root type of heirarchy.
- Root type of heirarchy means everything from integer, double, boolean, etc. inherits from object.
- Either it is a custom class or .NET data type, everything inherits from the Object class.



















7


