## Boxing and Unboxing :

- Boxing means moving from Value type to Reference type and Unboxing is vice versa.
- Quite a memory and CPU intensive operation.
- Must be avoided in code.

```csharp
namespace Basic
{
    class Program
    {
        static void Main(string[] args){
           int i = 10;
           int y = i;

           object o = y;  // Boxing - Copying of data from Stack to heap.
           int z = (int)o;  // Unboxing - Copying of data from Heap to Stack.

           Console.WriteLine(y);
           Console.WriteLine(z);
        }

    }
}

```
