// task1
// Person person = new Person();
// person.FirstName = "Shahrom";
// person.LastName = "Sharipov";
// person.Age = 26;
// person.Address = "Dushanbe";
// Console.WriteLine($"My name is {person.GetFullName()}");
// Console.WriteLine($"My birth year is {person.GetBirthYear()}.");

// task2
// Rectangle rectangle = new Rectangle();
// rectangle.Width = 7;
// rectangle.Height = 5;
// Console.WriteLine($"Area = {rectangle.GetArea()}");
// rectangle.Width = 10;
// rectangle.Height = 3;
// Console.WriteLine($"New area = {rectangle.GetArea()}");

// task3
// Student[] students =
// {
//     new Student("Alice", 10, new int[] { 85, 90, 92 }),
//     new Student("Bob", 11, new int[] { 78, 82, 88 }),
//     new Student("Charlie", 12, new int[] { 90, 95, 93 }),
//     new Student("David", 10, new int[] { 80, 85, 87 }),
//     new Student("Eve", 11, new int[] { 88, 90, 91 })
// };
//
// foreach (Student student in students)
// {
//     double average = student.GetAverage();
//
//     if (average > 85)
//     {
//         Console.WriteLine($"Congratulations {student.Name}! Your average score is {average:F1} in grade {student.GradeLevel}.");
//         Console.WriteLine("Keep up the good work!");
//     }
//     else if (average < 70)
//     {
//         Console.WriteLine($"{student.Name}, your average score is {average:F1} in grade {student.GradeLevel}.");
//         Console.WriteLine("We are here to support you. Please seek additional help if needed.");
//     }
//     else
//     {
//         Console.WriteLine($"{student.Name}, good job! Your average score is {average:F1} in grade {student.GradeLevel}.");
//         Console.WriteLine("Keep working hard for even better results!");
//     }
//
//     Console.WriteLine("------------------------------------------------");
// }

// task4
// Car myCar = new Car("Toyota", "Camry", 2022);
// Console.WriteLine($"Make: {myCar.Make}");
// Console.WriteLine($"Model: {myCar.Model}");
// Console.WriteLine($"Year: {myCar.Year}");
// Console.WriteLine($"Mileage: {myCar.Mileage:0.##} miles");
// Console.WriteLine($"Fuel level: {myCar.Fuel:0.##} gallons");
// myCar.AddFuel(10);
// myCar.Drive(100);
// myCar.AddFuel(10);
// Console.WriteLine("\nAfter the trip and refueling:");
// Console.WriteLine($"Mileage: {myCar.Mileage:0.##} miles");
// Console.WriteLine($"Fuel level: {myCar.Fuel:0.##} gallons");

public class Program
{
    public static void Main()
    {
    }
}

public class Person
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int Age { get; set; }
    public string Address { get; set; } = "";

    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }

    public int GetBirthYear()
    {
        return DateTime.Now.Year - Age;
    }
}

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double GetArea()
    {
        return Width * Height;
    }
}

public class Student
{
    public string Name { get; set; }
    public int GradeLevel { get; set; }
    public int[] Scores { get; set; }

    public Student(string name, int gradeLevel, int[] scores)
    {
        Name = name;
        GradeLevel = gradeLevel;
        Scores = scores;
    }

    public double GetAverage()
    {
        int sum = 0;

        for (int i = 0; i < Scores.Length; i++)
        {
            sum += Scores[i];
        }

        return (double)sum / Scores.Length;
    }
}

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Mileage { get; private set; }
    public double Fuel { get; private set; }

    private const double MilesPerGallon = 20.0;

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        Mileage = 0;
        Fuel = 0;
    }

    public void Drive(double miles)
    {
        if (miles <= 0)
        {
            Console.WriteLine("Distance must be greater than 0.");
            return;
        }

        double neededFuel = miles / MilesPerGallon;

        if (Fuel < neededFuel)
        {
            Console.WriteLine("Not enough fuel. Please refuel.");
            return;
        }

        Fuel -= neededFuel;
        Mileage += miles;
        Console.WriteLine($"You have driven {miles:0.##} miles. Current mileage: {Mileage:0.##} miles. Remaining fuel: {Fuel:0.##} gallons.");
    }

    public void AddFuel(double gallons)
    {
        if (gallons <= 0)
        {
            Console.WriteLine("Fuel amount must be greater than 0.");
            return;
        }

        Fuel += gallons;
        Console.WriteLine($"Added {gallons:0.##} gallons of fuel. Current fuel level: {Fuel:0.##} gallons.");
    }
}
