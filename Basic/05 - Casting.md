## Implicit casting :

- When we try to move from a lower data type (integer) to higher data type (double), casting happens automatically or implicitly.
- lower/higher (in terms of range).
- There is not data loss in such case.

```csharp
namespace Basic
{
    class Program
    {
        static void Main(string[] args){
            int a = 100;
            double d = 132.232;

            Console.WriteLine(d);

            d = a; // implicit casting

            Console.WriteLine(d);
        }
    }
}
```

## Explicit Casting :

- There are chances of data loss when assigning a value stored in double to a integer variable.
- The decimal part will be omitted.
- C# compiler will throw warning.
- Thus, using explicit casting we tell compiler that we want the data loss to happen.

```csharp
namespace Basic
{
    class Program
    {
        static void Main(string[] args){
            int a = 100;
            double d = 132.232;

            Console.WriteLine(a);

            a = (int)d; // explicit casting

            Console.WriteLine(a);
        }
    }
}
```

## NOTE : Converting and Casting are different concepts :

- Casting means moving from one data type to another data type.
- Converting means to move from different data type families like for example from a string to number. Sometimes conversion won't happen due to incorrect data passed.
- We use Convert class in .NET which have functions ToInt, ToString, etc.







