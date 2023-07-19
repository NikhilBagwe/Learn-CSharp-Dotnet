## LINQ : Language Integrated Query

- Linq is wherein we can write the query inside our C# code.
- We can fire it on collections and other data sources.

```csharp
namespace Basic
{
    class Program
    {
        static void Main(string[] args){
           List<Customer> custs = new List<Customer>();

           custs.Add(new Customer() {name = "Nikhil", country = "India"});
           custs.Add(new Customer() {name = "Om", country = "India"});
           custs.Add(new Customer() {name = "Joon", country = "Korea"});
           custs.Add(new Customer() {name = "Mike", country = "US"});
           custs.Add(new Customer() {name = "Jay", country = "India"});

           var custFiltered = (from temp in custs
                                where temp.country == "US"
                                select temp);

            foreach(var item in custFiltered)
            {
                Console.WriteLine(item.name);
            }
        }

        public class Customer
        {
            public string name = "";
            public string country = "";
        }

    }
}
```
