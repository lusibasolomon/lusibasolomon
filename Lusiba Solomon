public class BankAccount
{
    // Private balance field
    private decimal _balance;

    // Read-only Balance property
    public decimal Balance
    {
        get
        {
            return _balance;
        }
    }

    // Deposit method
    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative.");
        }

        _balance += amount;
    }

    // Withdraw method
    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Withdrawal amount cannot be negative.");
        }

        if (amount > _balance)
        {
            throw new InvalidOperationException("Insufficient funds. Overdraft is not allowed.");
        }

        _balance -= amount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a bank account
        BankAccount account = new BankAccount();

        Console.WriteLine("BANK ACCOUNT SYSTEM");
        Console.WriteLine("-------------------");

        // Deposit money
        account.Deposit(100000);
        Console.WriteLine("Deposited: 100000 UGX");
        Console.WriteLine("Current Balance: " + account.Balance + " UGX");

        // Withdraw money
        account.Withdraw(30000);
        Console.WriteLine("Withdrawn: 30000 UGX");
        Console.WriteLine("Current Balance: " + account.Balance + " UGX");

        // Try a negative deposit
        try
        {
            account.Deposit(-5000);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Try a negative withdrawal
        try
        {
            account.Withdraw(-10000);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // Try to withdraw more than the balance
        try
        {
            account.Withdraw(100000);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("-------------------");
        Console.WriteLine("Final Balance: " + account.Balance + " UGX");
    }
}
