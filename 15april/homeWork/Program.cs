_ = 0;

// task1
// Book book = new Book("Agar javoni medonist", "Bashir Usmon", 2019);
// book.GetInfo();
// Console.WriteLine(book.IsPublishedRecently());

// task2
// Console.Write("Enter circle radius: ");
// string input = Console.ReadLine() ?? "";
//
// if (double.TryParse(input, out double userRadius) && userRadius >= 0)
// {
//     Circle circle = new Circle(userRadius);
//     Console.WriteLine($"Radius: {circle.GetRadius():F2}");
//     Console.WriteLine($"Area: {circle.GetArea():F2}");
//     Console.WriteLine($"Diameter: {circle.GetDiameter():F2}");
//     Console.WriteLine($"Circumference: {circle.GetCircumference():F2}");
// }
// else
// {
//     Console.WriteLine("Invalid input. Please enter a non-negative number.");
// }

// task3
// Date date = new Date();
// date.SetDate(1, 12, 2023);
// Console.WriteLine(date.ToString());

// task4
// BankAccount account = new BankAccount(1001, "John Doe", 5000.00m);
// Console.WriteLine($"AccountId: {account.AccountId}");
// Console.WriteLine($"Owner: {account.OwnerName}");
// Console.WriteLine($"Balance: {account.Balance:F2}");
// Console.WriteLine();
// account.Deposit(1000.00m);
// account.Withdraw(200.00m);
// account.FreezeAccount();
// account.Deposit(500.00m);
// account.UnfreezeAccount();
// account.Deposit(500.00m);
// Console.WriteLine($"\nFinal balance: {account.Balance:F2}");

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
    }

    public bool IsPublishedRecently()
    {
        return Year > 2010;
    }
}

public class Circle
{
    private double radius;
    private double pi = 3.14159;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle()
    {
        radius = 0.0;
    }

    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    public double GetRadius()
    {
        return radius;
    }

    public double GetArea()
    {
        return pi * radius * radius;
    }

    public double GetDiameter()
    {
        return radius * 2;
    }

    public double GetCircumference()
    {
        return 2 * pi * radius;
    }
}

public class Date
{
    private int day;
    private int month;
    private int year;

    public int Day
    {
        get { return day; }
        set { day = value; }
    }

    public int Month
    {
        get { return month; }
        set { month = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public Date() : this(1, 1, 1)
    {
    }

    public Date(int day) : this(day, 1, 1)
    {
    }

    public Date(int day, int month) : this(day, month, 1)
    {
    }

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public void SetDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public int GetDay()
    {
        return day;
    }

    public int GetMonth()
    {
        return month;
    }

    public int GetYear()
    {
        return year;
    }

    public override string ToString()
    {
        return $"{day:D2}/{month:D2}/{year:D4}";
    }
}

public class BankAccount
{
    private readonly int accountId;
    private decimal balance;
    private bool isFrozen;

    public string OwnerName { get; set; }
    public int AccountId => accountId;
    public decimal Balance => balance;
    public bool IsFrozen => isFrozen;

    public BankAccount(int accountId, string ownerName, decimal initialBalance)
    {
        if (accountId <= 0)
        {
            throw new ArgumentException("AccountId must be greater than 0.");
        }

        if (string.IsNullOrWhiteSpace(ownerName))
        {
            throw new ArgumentException("OwnerName cannot be empty.");
        }

        if (initialBalance < 0)
        {
            throw new ArgumentException("Initial balance cannot be negative.");
        }

        this.accountId = accountId;
        OwnerName = ownerName;
        balance = initialBalance;
        isFrozen = false;
    }

    public BankAccount(int accountId, decimal initialBalance, string ownerName)
        : this(accountId, ownerName, initialBalance)
    {
    }

    public void Deposit(decimal amount)
    {
        if (isFrozen)
        {
            Console.WriteLine("Operation rejected: account is frozen.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than 0.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Deposit: {amount:F2}. Current balance: {balance:F2}");
    }

    public void Withdraw(decimal amount)
    {
        if (isFrozen)
        {
            Console.WriteLine("Operation rejected: account is frozen.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than 0.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Withdraw: {amount:F2}. Current balance: {balance:F2}");
    }

    public void FreezeAccount()
    {
        isFrozen = true;
        Console.WriteLine("Account is frozen.");
    }

    public void UnfreezeAccount()
    {
        isFrozen = false;
        Console.WriteLine("Account is unfrozen.");
    }
}
