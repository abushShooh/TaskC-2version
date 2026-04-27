BankService bankService = new BankService();
bool work = true;

while (work)
{
    ShowMenu();
    Console.Write("Choose action: ");
    string command = Console.ReadLine() ?? "";

    switch (command)
    {
        case "1":
            CreateSavingsAccount(bankService);
            break;
        case "2":
            CreateCheckingAccount(bankService);
            break;
        case "3":
            ShowAllAccounts(bankService);
            break;
        case "4":
            ShowAccountById(bankService);
            break;
        case "5":
            UpdateAccountHolder(bankService);
            break;
        case "6":
            DeleteAccount(bankService);
            break;
        case "7":
            Deposit(bankService);
            break;
        case "8":
            Withdraw(bankService);
            break;
        case "9":
            Transfer(bankService);
            break;
        case "10":
            ShowStatement(bankService);
            break;
        case "0":
            work = false;
            Console.WriteLine("Program finished.");
            break;
        default:
            Console.WriteLine("Wrong command.");
            break;
    }

    Console.WriteLine();
}

static void ShowMenu()
{
    Console.WriteLine("===== MINI BANKING =====");
    Console.WriteLine("1  - Create savings account");
    Console.WriteLine("2  - Create checking account");
    Console.WriteLine("3  - Show all accounts");
    Console.WriteLine("4  - Show account details");
    Console.WriteLine("5  - Update account holder");
    Console.WriteLine("6  - Delete account");
    Console.WriteLine("7  - Deposit");
    Console.WriteLine("8  - Withdraw");
    Console.WriteLine("9  - Transfer");
    Console.WriteLine("10 - Statement with filters");
    Console.WriteLine("0  - Exit");
}

static void CreateSavingsAccount(BankService bankService)
{
    Console.Write("Account id: ");
    string id = Console.ReadLine() ?? "";

    Console.Write("Holder name: ");
    string holderName = Console.ReadLine() ?? "";

    Console.Write("Currency (UZS, USD...): ");
    string currency = (Console.ReadLine() ?? "").Trim().ToUpper();

    bool created = bankService.CreateSavingsAccount(id, holderName, currency, out string message);
    Console.WriteLine(message);

    if (created)
    {
        IBankAccount? account = bankService.GetAccountById(id);
        if (account != null)
        {
            PrintAccount(account);
        }
    }
}

static void CreateCheckingAccount(BankService bankService)
{
    Console.Write("Account id: ");
    string id = Console.ReadLine() ?? "";

    Console.Write("Holder name: ");
    string holderName = Console.ReadLine() ?? "";

    Console.Write("Currency (UZS, USD...): ");
    string currency = (Console.ReadLine() ?? "").Trim().ToUpper();

    decimal overdraft = ReadDecimal("Overdraft limit: ");

    bool created = bankService.CreateCheckingAccount(id, holderName, currency, overdraft, out string message);
    Console.WriteLine(message);

    if (created)
    {
        IBankAccount? account = bankService.GetAccountById(id);
        if (account != null)
        {
            PrintAccount(account);
        }
    }
}

static void ShowAllAccounts(BankService bankService)
{
    List<IBankAccount> accounts = bankService.GetAccounts();

    if (accounts.Count == 0)
    {
        Console.WriteLine("No accounts.");
        return;
    }

    foreach (IBankAccount account in accounts)
    {
        PrintAccount(account);
    }
}

static void ShowAccountById(BankService bankService)
{
    Console.Write("Enter account id: ");
    string id = Console.ReadLine() ?? "";

    IBankAccount? account = bankService.GetAccountById(id);
    if (account == null)
    {
        Console.WriteLine("Account not found.");
        return;
    }

    PrintAccount(account);
}

static void UpdateAccountHolder(BankService bankService)
{
    Console.Write("Enter account id: ");
    string id = Console.ReadLine() ?? "";

    Console.Write("Enter new holder name: ");
    string holderName = Console.ReadLine() ?? "";

    bool updated = bankService.UpdateHolderName(id, holderName, out string message);
    Console.WriteLine(message);

    if (updated)
    {
        IBankAccount? account = bankService.GetAccountById(id);
        if (account != null)
        {
            PrintAccount(account);
        }
    }
}

static void DeleteAccount(BankService bankService)
{
    Console.Write("Enter account id: ");
    string id = Console.ReadLine() ?? "";

    bool deleted = bankService.DeleteAccount(id, out string message);
    Console.WriteLine(message);

    if (deleted)
    {
        Console.WriteLine("Account deleted from system.");
    }
}

static void Deposit(BankService bankService)
{
    Console.Write("Account id: ");
    string accountId = Console.ReadLine() ?? "";

    decimal amount = ReadDecimal("Amount: ");

    Console.Write("Currency: ");
    string currency = (Console.ReadLine() ?? "").Trim().ToUpper();

    Transaction transaction = bankService.Deposit(accountId, amount, currency);
    PrintTransactionResult(transaction);
}

static void Withdraw(BankService bankService)
{
    Console.Write("Account id: ");
    string accountId = Console.ReadLine() ?? "";

    decimal amount = ReadDecimal("Amount: ");

    Console.Write("Currency: ");
    string currency = (Console.ReadLine() ?? "").Trim().ToUpper();

    Transaction transaction = bankService.Withdraw(accountId, amount, currency);
    PrintTransactionResult(transaction);
}

static void Transfer(BankService bankService)
{
    Console.Write("From account id: ");
    string fromAccountId = Console.ReadLine() ?? "";

    Console.Write("To account id: ");
    string toAccountId = Console.ReadLine() ?? "";

    decimal amount = ReadDecimal("Amount: ");

    Console.Write("Currency: ");
    string currency = (Console.ReadLine() ?? "").Trim().ToUpper();

    Transaction transaction = bankService.Transfer(fromAccountId, toAccountId, amount, currency);
    PrintTransactionResult(transaction);
}

static void ShowStatement(BankService bankService)
{
    Console.Write("Account id: ");
    string accountId = Console.ReadLine() ?? "";

    IBankAccount? account = bankService.GetAccountById(accountId);
    if (account == null)
    {
        Console.WriteLine("Account not found.");
        return;
    }

    DateTime? fromDate = ReadDateOrEmpty("From date (yyyy-MM-dd or empty): ");
    DateTime? toDate = ReadDateOrEmpty("To date (yyyy-MM-dd or empty): ");
    TransactionType? type = ReadTransactionTypeFilter();

    List<Transaction> statement = bankService.GetAccountStatement(accountId, fromDate, toDate, type);

    if (statement.Count == 0)
    {
        Console.WriteLine("No transactions for selected filters.");
        return;
    }

    foreach (Transaction transaction in statement)
    {
        string amountWithSign = FormatAmountForAccount(transaction, accountId);
        string relation = FormatTransferRelation(transaction, accountId);

        Console.WriteLine(
            $"[{transaction.CreatedAt:yyyy-MM-dd}] {transaction.Type,-8} {amountWithSign,15} {transaction.Currency} {transaction.Status} {relation}");

        if (transaction.Status == TransactionStatus.Rejected && !string.IsNullOrWhiteSpace(transaction.Reason))
        {
            Console.WriteLine($"Reason: {transaction.Reason}");
        }
    }
}

static void PrintAccount(IBankAccount account)
{
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine($"Type: {account.GetType().Name}");
    Console.WriteLine($"Id: {account.Id}");
    Console.WriteLine($"Holder: {account.HolderName}");
    Console.WriteLine($"Currency: {account.Currency}");
    Console.WriteLine($"Balance: {account.Balance:N2}");

    if (account is CheckingAccount checkingAccount)
    {
        Console.WriteLine($"Overdraft limit: {checkingAccount.OverdraftLimit:N2}");
    }
}

static void PrintTransactionResult(Transaction transaction)
{
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine($"Transaction id: {transaction.Id}");
    Console.WriteLine($"Type: {transaction.Type}");
    Console.WriteLine($"Amount: {transaction.Amount:N2} {transaction.Currency}");
    Console.WriteLine($"Status: {transaction.Status}");

    if (!string.IsNullOrWhiteSpace(transaction.Reason))
    {
        Console.WriteLine($"Reason: {transaction.Reason}");
    }
}

static string FormatAmountForAccount(Transaction transaction, string accountId)
{
    string sign = "";

    if (transaction.Type == TransactionType.Deposit && transaction.ToAccountId == accountId)
    {
        sign = "+";
    }
    else if (transaction.Type == TransactionType.Withdraw && transaction.FromAccountId == accountId)
    {
        sign = "-";
    }
    else if (transaction.Type == TransactionType.Transfer)
    {
        if (transaction.FromAccountId == accountId)
        {
            sign = "-";
        }
        else if (transaction.ToAccountId == accountId)
        {
            sign = "+";
        }
    }

    return sign + transaction.Amount.ToString("N2");
}

static string FormatTransferRelation(Transaction transaction, string accountId)
{
    if (transaction.Type != TransactionType.Transfer)
    {
        return "";
    }

    if (transaction.FromAccountId == accountId)
    {
        return "(To: " + transaction.ToAccountId + ")";
    }

    if (transaction.ToAccountId == accountId)
    {
        return "(From: " + transaction.FromAccountId + ")";
    }

    return "";
}

static decimal ReadDecimal(string text)
{
    while (true)
    {
        Console.Write(text);
        string input = Console.ReadLine() ?? "";

        if (decimal.TryParse(input, out decimal value))
        {
            return value;
        }

        Console.WriteLine("Enter valid decimal number.");
    }
}

static DateTime? ReadDateOrEmpty(string text)
{
    while (true)
    {
        Console.Write(text);
        string input = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(input))
        {
            return null;
        }

        if (DateTime.TryParse(input, out DateTime date))
        {
            return date;
        }

        Console.WriteLine("Wrong date format.");
    }
}

static TransactionType? ReadTransactionTypeFilter()
{
    while (true)
    {
        Console.WriteLine("Transaction type filter:");
        Console.WriteLine("0 - All");
        Console.WriteLine("1 - Deposit");
        Console.WriteLine("2 - Withdraw");
        Console.WriteLine("3 - Transfer");
        Console.Write("Choose: ");
        string input = Console.ReadLine() ?? "";

        switch (input)
        {
            case "0":
                return null;
            case "1":
                return TransactionType.Deposit;
            case "2":
                return TransactionType.Withdraw;
            case "3":
                return TransactionType.Transfer;
            default:
                Console.WriteLine("Wrong command.");
                break;
        }
    }
}
