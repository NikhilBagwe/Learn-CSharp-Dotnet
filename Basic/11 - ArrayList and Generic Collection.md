##  Array and ArrayList :

```csharp
namespace Basic
{
    class Program
    {
        static void Main(string[] args){
           // Array - stores a definite amount of values of same data type.
           int[] arr = new int[5];

           arr[0] = 10;
           arr[1] = 100;
           arr[2] = 1000;

           Console.WriteLine(arr[0]);
           Console.WriteLine(arr);

           // ArrayList - Can store n number of values of different data types.
           ArrayList list = new ArrayList();
           list.Add(2);
           list.Add("nik");

           Console.WriteLine(list[1]);
           Console.WriteLine(list);
        }

    }
}
```
- Array can store a limited amount of values which are defined at the time of it's initialization.
- Arrays are strongly typed  i.e store data of only one data type.
- Thus, we use ArrayList.
- But using ArrayList comes at a cost.
- If we hover over the .Add() method, an object is getting stored into arraylist.
- Thus, a lot of boxing and unboxing takes place.
- Arrays are better at performance than Arraylist.


## Generic Collection :

- Gives us best of both worlds.
- In Generic List, our array becomes flexible in size also strongly typed as we define our data type during declaration.
- If you now hover on Add(), only data of particular type can be inserted, not an object.

```csharp
namespace Basic
{
    class Program
    {
        static void Main(string[] args){
           List<int> list1 = new List<int>();
           list1.Add(16);
           list1.Add(65);

           List<string> lst2 = new List<string>();

           Console.WriteLine(list1[1]);
        }

    }
}
```


















