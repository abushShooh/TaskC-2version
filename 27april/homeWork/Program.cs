bool work = true;

while (work)
{
    ShowMenu();
    Console.Write("Choose task: ");
    string command = Console.ReadLine() ?? "";

    switch (command)
    {
        case "1":
            RunTask1();
            break;
        case "2":
            RunTask2();
            break;
        case "3":
            RunTask3();
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
    Console.WriteLine("===== HOME WORK =====");
    Console.WriteLine("1 - Task 1 (IVehicle / Car)");
    Console.WriteLine("2 - Task 2 (Animal / Dog)");
    Console.WriteLine("3 - Task 3 (Book / Interfaces)");
    Console.WriteLine("0 - Exit");
}

static void RunTask1()
{
    Console.WriteLine("Task 1");
    Car car = new Car(0);

    int fuel = ReadInt("Enter amount of gasoline: ");
    bool refueled = car.Refuel(fuel);

    if (refueled)
    {
        car.Drive();
    }
}

static void RunTask2()
{
    Console.WriteLine("Task 2");
    Console.Write("Enter dog name: ");
    string dogName = Console.ReadLine() ?? "";

    Dog dog = new Dog();
    dog.SetName(dogName);

    Console.WriteLine(dog.GetName());
    dog.Eat();
}

static void RunTask3()
{
    Console.WriteLine("Task 3");
    Console.Write("Enter book title: ");
    string title = Console.ReadLine() ?? "";

    Console.Write("Enter author: ");
    string author = Console.ReadLine() ?? "";

    Book book = new Book();
    book.SetTitle(title);
    book.SetAuthor(author);

    book.Read();
    book.Borrow();
    book.ReturnBook();
}

static int ReadInt(string text)
{
    while (true)
    {
        Console.Write(text);
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int value))
        {
            return value;
        }

        Console.WriteLine("Enter only number.");
    }
}
