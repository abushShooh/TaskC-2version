public abstract class BankAccount : IBankAccount
{
    private readonly List<Transaction> statement = new List<Transaction>();

    public string Id { get; private set; }
    public string HolderName { get; set; }
    public string Currency { get; private set; }
    public decimal Balance { get; protected set; }

    protected BankAccount(string id, string holderName, string currency)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("Account id cannot be empty.");
        }

        if (string.IsNullOrWhiteSpace(holderName))
        {
            throw new ArgumentException("Holder name cannot be empty.");
        }

        if (string.IsNullOrWhiteSpace(currency))
        {
            throw new ArgumentException("Currency cannot be empty.");
        }

        Id = id.Trim();
        HolderName = holderName.Trim();
        Currency = currency.Trim().ToUpper();
        Balance = 0;
    }

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be greater than 0.");
        }

        Balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be greater than 0.");
        }

        if (Balance < amount)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        Balance -= amount;
    }

    public List<Transaction> GetStatement()
    {
        return statement;
    }
}
