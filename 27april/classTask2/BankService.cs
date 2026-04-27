public class BankService
{
    private readonly List<IBankAccount> accounts = new List<IBankAccount>();
    private readonly List<Transaction> transactions = new List<Transaction>();
    private int nextTransactionNumber = 1;

    public bool CreateSavingsAccount(string id, string holderName, string currency, out string message)
    {
        if (!ValidateCreateData(id, holderName, currency, out message))
        {
            return false;
        }

        IBankAccount account = new SavingsAccount(id, holderName, currency);
        accounts.Add(account);
        message = "Savings account created.";
        return true;
    }

    public bool CreateCheckingAccount(string id, string holderName, string currency, decimal overdraftLimit, out string message)
    {
        if (!ValidateCreateData(id, holderName, currency, out message))
        {
            return false;
        }

        if (overdraftLimit < 0)
        {
            message = "Overdraft limit cannot be negative.";
            return false;
        }

        IBankAccount account = new CheckingAccount(id, holderName, currency, overdraftLimit);
        accounts.Add(account);
        message = "Checking account created.";
        return true;
    }

    public List<IBankAccount> GetAccounts()
    {
        return accounts;
    }

    public IBankAccount? GetAccountById(string accountId)
    {
        return accounts.FirstOrDefault(account =>
            account.Id.Equals(accountId.Trim(), StringComparison.OrdinalIgnoreCase));
    }

    public bool UpdateHolderName(string accountId, string newHolderName, out string message)
    {
        IBankAccount? account = GetAccountById(accountId);
        if (account == null)
        {
            message = "Account not found.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(newHolderName))
        {
            message = "Holder name cannot be empty.";
            return false;
        }

        account.HolderName = newHolderName.Trim();
        message = "Holder name updated.";
        return true;
    }

    public bool DeleteAccount(string accountId, out string message)
    {
        IBankAccount? account = GetAccountById(accountId);
        if (account == null)
        {
            message = "Account not found.";
            return false;
        }

        if (account.Balance != 0)
        {
            message = "Cannot close account. Balance must be zero.";
            return false;
        }

        bool hasPending = transactions.Any(transaction =>
            transaction.Status == TransactionStatus.Pending &&
            (transaction.FromAccountId == account.Id || transaction.ToAccountId == account.Id));

        if (hasPending)
        {
            message = "Cannot close account with pending transactions.";
            return false;
        }

        accounts.Remove(account);
        message = "Account closed.";
        return true;
    }

    public Transaction Deposit(string accountId, decimal amount, string currency)
    {
        IBankAccount? account = GetAccountById(accountId);
        Transaction transaction = NewTransaction(TransactionType.Deposit, amount, currency, null, accountId);

        if (account == null)
        {
            RejectTransaction(transaction, "Account not found.");
            SaveTransaction(transaction);
            return transaction;
        }

        if (!IsCurrencyMatch(account.Currency, currency))
        {
            RejectTransaction(transaction, "Transaction currency does not match account currency.");
            SaveTransaction(transaction, account);
            return transaction;
        }

        try
        {
            account.Deposit(amount);
            CompleteTransaction(transaction);
        }
        catch (Exception ex)
        {
            RejectTransaction(transaction, ex.Message);
        }

        SaveTransaction(transaction, account);
        return transaction;
    }

    public Transaction Withdraw(string accountId, decimal amount, string currency)
    {
        IBankAccount? account = GetAccountById(accountId);
        Transaction transaction = NewTransaction(TransactionType.Withdraw, amount, currency, accountId, null);

        if (account == null)
        {
            RejectTransaction(transaction, "Account not found.");
            SaveTransaction(transaction);
            return transaction;
        }

        if (!IsCurrencyMatch(account.Currency, currency))
        {
            RejectTransaction(transaction, "Transaction currency does not match account currency.");
            SaveTransaction(transaction, account);
            return transaction;
        }

        try
        {
            account.Withdraw(amount);
            CompleteTransaction(transaction);
        }
        catch (Exception ex)
        {
            RejectTransaction(transaction, ex.Message);
        }

        SaveTransaction(transaction, account);
        return transaction;
    }

    public Transaction Transfer(string fromAccountId, string toAccountId, decimal amount, string currency)
    {
        IBankAccount? fromAccount = GetAccountById(fromAccountId);
        IBankAccount? toAccount = GetAccountById(toAccountId);
        Transaction transaction = NewTransaction(TransactionType.Transfer, amount, currency, fromAccountId, toAccountId);

        List<IBankAccount> relatedAccounts = new List<IBankAccount>();
        if (fromAccount != null)
        {
            relatedAccounts.Add(fromAccount);
        }

        if (toAccount != null && !relatedAccounts.Any(account => account.Id == toAccount.Id))
        {
            relatedAccounts.Add(toAccount);
        }

        if (fromAccount == null || toAccount == null)
        {
            RejectTransaction(transaction, "Source or destination account not found.");
            SaveTransaction(transaction, relatedAccounts.ToArray());
            return transaction;
        }

        if (fromAccount.Id.Equals(toAccount.Id, StringComparison.OrdinalIgnoreCase))
        {
            RejectTransaction(transaction, "Cannot transfer to the same account.");
            SaveTransaction(transaction, relatedAccounts.ToArray());
            return transaction;
        }

        if (!IsCurrencyMatch(fromAccount.Currency, currency) || !IsCurrencyMatch(toAccount.Currency, currency))
        {
            RejectTransaction(transaction, "Transaction currency does not match account currency.");
            SaveTransaction(transaction, relatedAccounts.ToArray());
            return transaction;
        }

        try
        {
            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);
            CompleteTransaction(transaction);
        }
        catch (Exception ex)
        {
            RejectTransaction(transaction, ex.Message);
        }

        SaveTransaction(transaction, relatedAccounts.ToArray());
        return transaction;
    }

    public List<Transaction> GetAccountStatement(
        string accountId,
        DateTime? fromDate,
        DateTime? toDate,
        TransactionType? type)
    {
        IBankAccount? account = GetAccountById(accountId);
        if (account == null)
        {
            return new List<Transaction>();
        }

        IEnumerable<Transaction> query = account.GetStatement();

        if (fromDate.HasValue)
        {
            DateTime from = fromDate.Value.Date;
            query = query.Where(transaction => transaction.CreatedAt >= from);
        }

        if (toDate.HasValue)
        {
            DateTime to = toDate.Value.Date.AddDays(1).AddTicks(-1);
            query = query.Where(transaction => transaction.CreatedAt <= to);
        }

        if (type.HasValue)
        {
            query = query.Where(transaction => transaction.Type == type.Value);
        }

        return query
            .OrderBy(transaction => transaction.CreatedAt)
            .ToList();
    }

    private bool ValidateCreateData(string id, string holderName, string currency, out string message)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            message = "Account id cannot be empty.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(holderName))
        {
            message = "Holder name cannot be empty.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(currency))
        {
            message = "Currency cannot be empty.";
            return false;
        }

        if (GetAccountById(id) != null)
        {
            message = "Account id must be unique.";
            return false;
        }

        message = "";
        return true;
    }

    private static bool IsCurrencyMatch(string accountCurrency, string transactionCurrency)
    {
        return accountCurrency.Equals(transactionCurrency.Trim(), StringComparison.OrdinalIgnoreCase);
    }

    private Transaction NewTransaction(
        TransactionType type,
        decimal amount,
        string currency,
        string? fromAccountId,
        string? toAccountId)
    {
        return new Transaction
        {
            Id = "TX-" + nextTransactionNumber.ToString("D5"),
            Type = type,
            Amount = amount,
            Currency = currency.Trim().ToUpper(),
            FromAccountId = fromAccountId,
            ToAccountId = toAccountId,
            CreatedAt = DateTime.Now,
            Status = TransactionStatus.Pending,
            Reason = ""
        };
    }

    private void SaveTransaction(Transaction transaction, params IBankAccount[] relatedAccounts)
    {
        transactions.Add(transaction);

        foreach (IBankAccount account in relatedAccounts)
        {
            account.GetStatement().Add(transaction);
        }

        nextTransactionNumber++;
    }

    private static void CompleteTransaction(Transaction transaction)
    {
        transaction.Status = TransactionStatus.Completed;
        transaction.Reason = "";
    }

    private static void RejectTransaction(Transaction transaction, string reason)
    {
        transaction.Status = TransactionStatus.Rejected;
        transaction.Reason = reason;
    }
}
