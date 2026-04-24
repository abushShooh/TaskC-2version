_ = 0;

// task1
// while (true)
// {
//     Console.Write("Enter first number: ");
//     double firstNum = Convert.ToDouble(Console.ReadLine());
//
//     Console.Write("Enter second number: ");
//     double secondNum = Convert.ToDouble(Console.ReadLine());
//
//     Console.Write("Enter operation (+, -, *, /): ");
//     string operation = Console.ReadLine() ?? "";
//
//     Calculator calculator = new Calculator(firstNum, secondNum);
//
//     switch (operation)
//     {
//         case "+":
//             Console.WriteLine(calculator.Sum());
//             break;
//         case "-":
//             Console.WriteLine(calculator.Subtract());
//             break;
//         case "*":
//             Console.WriteLine(calculator.Multiplication());
//             break;
//         case "/":
//             Console.WriteLine(calculator.Division());
//             break;
//         default:
//             Console.WriteLine("Wrong operation!");
//             break;
//     }
// }

// task2
// User[] users =
// {
//     new User("Ali", "Karimov", "ali123", "12345"),
//     new User("Zarina", "Rahimova", "zarina77", "qwerty"),
//     new User("Said", "Olimov", "said01", "11111"),
//     new User("Madina", "Nazarova", "madina22", "abcd"),
//     new User("Rustam", "Yusufov", "rustam99", "pass")
// };
//
// while (true)
// {
//     Console.Write("Enter username: ");
//     string userName = Console.ReadLine() ?? "";
//
//     Console.Write("Enter password: ");
//     string password = Console.ReadLine() ?? "";
//
//     User foundUser = null;
//
//     foreach (User user in users)
//     {
//         if (user.UserName == userName)
//         {
//             foundUser = user;
//             break;
//         }
//     }
//
//     if (foundUser != null)
//     {
//         foundUser.Login(userName, password);
//     }
//     else
//     {
//         Console.WriteLine("Login failed!");
//     }
// }

// task3
// Student student1 = new Student(1, "Shahrom", 20, 4.5);
// Student student2 = new Student(2, "Ali", 19, 3.8);
// student1.GetInfo();
// Console.WriteLine(student1.IsExcellentStudent());
// student2.GetInfo();
// Console.WriteLine(student2.IsExcellentStudent());

// task4
// Order order1 = new Order(101, "Ноутбук", 2, 2500.0m);
// Order order2 = new Order("Смартфон", 5);
// Order order3 = new Order("Наушники", 120.5m);
// Console.WriteLine("Информация о заказах:");
// order1.DisplayInfo();
// order2.DisplayInfo();
// order3.DisplayInfo();

public class Calculator
{
    public double FirstNumber { get; set; }
    public double SecondNumber { get; set; }

    public Calculator(double firstNum, double secondNum)
    {
        FirstNumber = firstNum;
        SecondNumber = secondNum;
    }

    public double Sum()
    {
        return FirstNumber + SecondNumber;
    }

    public double Subtract()
    {
        return FirstNumber - SecondNumber;
    }

    public double Multiplication()
    {
        return FirstNumber * SecondNumber;
    }

    public double Division()
    {
        if (SecondNumber == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0;
        }

        return FirstNumber / SecondNumber;
    }
}

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    private string password;

    public User(string firstName, string lastName, string userName, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        UserName = userName;
        this.password = password;
    }

    public void GetInfo()
    {
        Console.WriteLine($"FirstName: {FirstName}");
        Console.WriteLine($"LastName: {LastName}");
        Console.WriteLine($"UserName: {UserName}");
    }

    public void Login(string userName, string password)
    {
        if (UserName == userName && this.password == password)
        {
            Console.WriteLine($"Login successful! Welcome, Mr./Ms. {FirstName} {LastName}");
        }
        else
        {
            Console.WriteLine("Login failed!");
        }
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Avarage { get; set; }

    public Student(int id, string name, int age, double avarage)
    {
        Id = id;
        Name = name;
        Age = age;
        Avarage = avarage;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Id={Id}; Name: {Name}, Age: {Age}, Average Grade: {Avarage}");
    }

    public bool IsExcellentStudent()
    {
        return Avarage > 4.0;
    }
}

public class Order
{
    public int OrderNumber { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal TotalAmount { get; set; }

    public Order(int orderNumber, string productName, int productQuantity, decimal orderAmount)
    {
        OrderNumber = orderNumber;
        ProductName = productName;
        Quantity = productQuantity;
        TotalAmount = orderAmount;
    }

    public Order(string productName, int productQuantity)
    {
        OrderNumber = 0;
        ProductName = productName;
        Quantity = productQuantity;
        TotalAmount = 0;
    }

    public Order(string productName, decimal orderAmount)
    {
        OrderNumber = 0;
        ProductName = productName;
        Quantity = 0;
        TotalAmount = orderAmount;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"OrderNumber: {OrderNumber}");
        Console.WriteLine($"ProductName: {ProductName}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"TotalAmount: {TotalAmount}");
        Console.WriteLine("--------------------------------");
    }
}
