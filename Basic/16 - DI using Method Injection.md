## Method Injection :

- In MI we inject the dependent class object through a class method.
- In given example, Account class has a dependency on SavingAccount and CurrentAccount class.
- But we are not making there objects directly inside Account class.
- Instead we are injecting SavingAccount and CurrentAccount class objects directly into Account class PrintAccounts() method using Interface.

## Example code :

```csharp
public interface IAccount
{
    // abstract method
    void PrintDetails();
}

// Class implementing the Interface IAccount
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
    // We will not create a property nor a constructor. Just a parameterized method for Method Injection which accepts a parameter of type IAccount.
    // We pass obj of either SavingAccount or CurrentAccount class into it.
    public void PrintAccounts(IAccount account)
    {
        // Thus, we can now directly call the methods present inisde SavingAccount or CurrentAccount class.
        account.PrintDetails();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account sa = new Account();
        sa.PrintAccounts(new SavingAccount());

        Account ca = new Account();
        ca.PrintAccounts(new CurrentAccount());
    }
}

```
