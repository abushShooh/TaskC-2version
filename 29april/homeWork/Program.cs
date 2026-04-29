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
    Console.WriteLine("1 - Task 1 (Cache<T>)");
    Console.WriteLine("2 - Task 2 (Geometry)");
    Console.WriteLine("3 - Task 3 (Math operations)");
    Console.WriteLine("0 - Exit");
}

static void RunTask1()
{
    Console.WriteLine("Task 1");

    Cache<string>.Add("Hello cache");
    string cachedMessage = Cache<string>.Get(0);
    Console.WriteLine("String from cache: " + cachedMessage);

    Cache<string>.Remove(0);
    Console.WriteLine("String removed from cache.");

    Person person = new Person
    {
        Id = 1,
        Name = "Ali"
    };

    Cache<Person>.Add(person);
    Person cachedPerson = Cache<Person>.Get(0);
    Console.WriteLine("Person from cache: " + cachedPerson.GetInfo());

    Cache<Person>.Remove(0);
    Console.WriteLine("Person removed from cache.");
}

static void RunTask2()
{
    Console.WriteLine("Task 2");

    double circleRadius = 5;
    Console.WriteLine("Circle radius: " + circleRadius);
    Console.WriteLine("Circle area: " + Circle.CalcCircleArea(circleRadius));
    Console.WriteLine("Circle perimeter: " + Circle.CalcCirclePerimeter(circleRadius));

    Console.WriteLine();

    double rectangleLength = 6;
    double rectangleWidth = 4;
    Console.WriteLine("Rectangle length: " + rectangleLength);
    Console.WriteLine("Rectangle width: " + rectangleWidth);
    Console.WriteLine("Rectangle area: " + Rectangle.CalcRectangleArea(rectangleLength, rectangleWidth));
    Console.WriteLine("Rectangle perimeter: " + Rectangle.CalcRectanglePerimeter(rectangleLength, rectangleWidth));

    Console.WriteLine();

    double triangleBase = 8;
    double triangleHeight = 5;
    Console.WriteLine("Triangle base: " + triangleBase);
    Console.WriteLine("Triangle height: " + triangleHeight);
    Console.WriteLine("Triangle area: " + Triangle.CalcTriangleArea(triangleBase, triangleHeight));
    Console.WriteLine("Triangle perimeter: " + Triangle.CalcTrianglePerimeter(3, 4, 5));
}

static void RunTask3()
{
    Console.WriteLine("Task 3");

    double a = 12;
    double b = 4;

    Console.WriteLine($"a = {a}, b = {b}");
    Console.WriteLine("Add: " + MathOperations.Add(a, b));
    Console.WriteLine("Subtract: " + MathOperations.Subtract(a, b));
    Console.WriteLine("Multiply: " + MathOperations.Multiply(a, b));
    Console.WriteLine("Divide: " + MathOperations.Divide(a, b));
}
