public enum TransactionType
{
    Deposit = 1,
    Withdraw = 2,
    Transfer = 3
}

public enum TransactionStatus
{
    Pending = 1,
    Completed = 2,
    Rejected = 3
}

public class Transaction
{
    public string Id { get; set; } = "";
    public TransactionType Type { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "";
    public string? FromAccountId { get; set; }
    public string? ToAccountId { get; set; }
    public DateTime CreatedAt { get; set; }
    public TransactionStatus Status { get; set; }
    public string Reason { get; set; } = "";
}
