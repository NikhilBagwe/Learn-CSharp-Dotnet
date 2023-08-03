## Property Injection :

1. Create an Interface.
2. Then implement the abstract methods present in that interface in a class.
![img_1](https://github.com/NikhilBagwe/Learn-CSharp-Dotnet/assets/67143015/be2abb5b-caf6-4e2b-8432-0e3091107ac8)

- As shown in above example, SavingAccount and CurrentAccount class implement the abstract methods present inside the Interface.
- Then the Account class is dependent on Interface to provide it with the objects of SavingAccount and CurrentAccount class.
- Thus, Account class dosen't require the to make the objects directly, instead they are injected into it.

## Example :

```csharp
public interface IAccount
{
    void PrintDetails();
}

class CurrentAccount : IAccount
{
    public void PrintDetails()
    {
        Console.WriteLine("Details of Current Account");
    }
}

class SavingAccount : IAccount
{
    public void PrintDetails()
    {
        Console.WriteLine("Details of Saving Account");
    }
}

class Account
{
    // Property Injection - I can either pass object of SavingAccount or CurrentAccount class
    public IAccount _account { get; set; }

    public void PrintAccounts()
    {
        _account.PrintDetails();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account sa = new Account();
        // Pass object of SavingAccount class into the '_account' property. 
        // Thus we are storing child class reference into Parent class property.
        sa._account = new SavingAccount();
        sa.PrintAccounts();

        Account ca = new Account();
        ca._account = new CurrentAccount();
        ca.PrintAccounts();
    }
}

```
- So using PI, we have successfully injected SavingAccount and CurrentAccount class objects into Account class using property.
