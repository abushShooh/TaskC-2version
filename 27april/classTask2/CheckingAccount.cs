public class CheckingAccount : BankAccount
{
    public decimal OverdraftLimit { get; private set; }

    public CheckingAccount(string id, string holderName, string currency, decimal overdraftLimit)
        : base(id, holderName, currency)
    {
        if (overdraftLimit < 0)
        {
            throw new ArgumentException("Overdraft limit cannot be negative.");
        }

        OverdraftLimit = overdraftLimit;
    }

    public override void Deposit(decimal amount)
    {
        base.Deposit(amount);
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be greater than 0.");
        }

        if (Balance - amount < -OverdraftLimit)
        {
            throw new InvalidOperationException($"Overdraft limit exceeded. Limit: {OverdraftLimit:N2} {Currency}");
        }

        Balance -= amount;
    }
}
