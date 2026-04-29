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
    Console.WriteLine("1 - Task 1 (Person / Student / Teacher)");
    Console.WriteLine("2 - Task 2 (Shape / Rectangle / Circle)");
    Console.WriteLine("3 - Task 3 (IDevice / Smart Home)");
    Console.WriteLine("0 - Exit");
}

static void RunTask1()
{
    Console.WriteLine("Task 1");

    Person person = new Person();
    person.Greet();

    Student student = new Student();
    student.SetAge(21);
    student.Greet();
    student.ShowAge();
    student.Study();

    Teacher teacher = new Teacher();
    teacher.Greet();
    teacher.Explain();
}

static void RunTask2()
{
    Console.WriteLine("Task 2");

    List<Shape> shapes = new List<Shape>
    {
        new Rectangle("Red", 5.5, 3.2),
        new Circle("Blue", 4)
    };

    foreach (Shape shape in shapes)
    {
        shape.PrintInfo();
        Console.WriteLine();
    }
}

static void RunTask3()
{
    Console.WriteLine("Task 3");

    Lamp lamp = new Lamp("Living room");
    Thermostat thermostat = new Thermostat("Bedroom");
    Lock smartLock = new Lock("Front door");

    List<IDevice> devices = new List<IDevice>
    {
        lamp,
        thermostat,
        smartLock
    };

    foreach (IDevice device in devices)
    {
        device.TurnOn();
    }

    lamp.SetBrightness(80);
    thermostat.SetTemperature(23.5);
    smartLock.LockDoor();
    smartLock.UnlockDoor();

    foreach (IDevice device in devices)
    {
        device.TurnOff();
    }
}
