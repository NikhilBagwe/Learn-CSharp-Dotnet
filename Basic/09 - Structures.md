## Structures :

- A sturcture is a composite and value type.
- So assigning an existing structure to a new structure, a fresh copy is assigned i.e copy by value.
- Structures are not similar to Classes as classes are Reference types.
- We can't assign values to properties while defining them in struct.
  
```csharp
namespace Basic
{
    public struct coordinates
    {
        public int x;
        public int y;
        public int z;

        public void MoveBy10(){
            x = x +10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           coordinates xyz = new coordinates();

           xyz.x = 10;
           xyz.y = 30;

           Console.WriteLine(xyz.x);
           Console.WriteLine(xyz.z);

        }
    }
}
```
