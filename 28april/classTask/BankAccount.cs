public class BankAccount
{
    public int AccountNumber { get; set; }
    public string Owner { get; set; }
    private decimal balance;

    public BankAccount(int accountNumber, string owner, decimal startBalance = 0m)
    {
        AccountNumber = accountNumber;
        Owner = owner;
        balance = startBalance;
    }

    public void TopUp(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Top up amount must be greater than 0.");
            return;
        }

        balance += amount;
        Console.WriteLine($"{amount} added to balance.");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than 0.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Not enough money in balance.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"{amount} withdrawn from balance.");
    }

    public void PrintStatement()
    {
        Console.WriteLine($"Account number: {AccountNumber}");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Balance: {balance}");
    }
}
