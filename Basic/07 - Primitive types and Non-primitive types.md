## Primitive data types  : 

- Also known as Value types.
- .NET defined data types are known as Primitive data types.
- They are inbuilt.
- eg: int, bool, etc.

## Non-primitive data types : 

- Also known as Reference types.
- Custom data types such as User-defined class.

## Value type :

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

## Reference types :

- Here 2 objects point to same memory address location.

```csharp
namespace Basic
{
    class Program
    {
        static void Main(string[] args){
            MyClass obj = new MyClass();
            obj.name = "Nikhil";

            MyClass obj1 = new MyClass();
            obj1 = obj; // Now both objects point/referenece to same memory address

            obj1.name = "Om"; // Thus, modifying one object will affect the other object also.

            Console.WriteLine(obj.name);
            Console.WriteLine(obj1.name);
        }

        class MyClass{
            public string name = "";
        }
    }
}
```

## Q. Why do we need Reference types ?

- When we create an object, we don't have any idea about what the data size of it can be.
- So the data size is unknown.
- Suppose if a huge data/file is loaded into an object and if we apply the concept of "Value type" here it will cost us a lot of memory.
- Thus, concept of Reference type is used in case of Objects because we cannot create a fresh copy of an object and then assign it to other object.
