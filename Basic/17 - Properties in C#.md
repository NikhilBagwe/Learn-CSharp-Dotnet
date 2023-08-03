## Properties  :

- Property in C# is a class member that exposes the class' private fields.
- Internally, C# properties are special methods called accessors.
- Internally, in a C# class, properties are nothing but a natural extension of data fields. 

```csharp
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //getters & setters = add security to fields by encapsulation
            //                    They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // set accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)

            Car car = new Car(400);

            // A car's speed cannot be so much. Thus, we used setter to handle such scenario.
            car.Speed = 1000000000;

            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }
    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        // Property 
        public int Speed
        {
            get { return speed; } // read

            set                   // write
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }

    }
}

```
