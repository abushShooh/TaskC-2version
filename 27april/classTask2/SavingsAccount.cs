public class SavingsAccount : BankAccount
{
    public SavingsAccount(string id, string holderName, string currency)
        : base(id, holderName, currency)
    {
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

        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Savings account cannot go below zero.");
        }

        Balance -= amount;
    }
}
