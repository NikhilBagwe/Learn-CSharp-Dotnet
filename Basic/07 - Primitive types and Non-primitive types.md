## Primitive data types  : 

- Also known as Value types and Reference types.
- .NET defined data types are known as Primitive data types.
- They are inbuilt.
- eg: int, bool, etc.

## Non-primitive data types : 

- Custom data types such as User-defined class.

## Value type Example :

- In value type, the complete value is copied into another variable and when you change the values assigned to varaibles, it won't have effect on each other.
- At the address location of 'i' value '10' is stored.
- At the address location of 'y' value '30' is stored.
- Both variables are stored at diff. locations.
- Any changes that we make to 'y' won't have any affect on 'i' as a fresh copy of 'i' was assigned to 'y'.
  
```csharp
namespace Basic
{
    class Program
    {
        static void Main(string[] args){
            // value type 
            int i = 10;
            int y = i;
            y = 30;

            Console.WriteLine(i);
            Console.WriteLine(y);
        }
    }
}
```
