List<Employee> employees = new List<Employee>
{
    new Employee
    {
        Id = 1,
        FirstName = "Alijon",
        LastName = "Zabirov",
        Age = 24,
        PhoneNumber = "881667007",
        Salary = 4000m
    },
    new Employee
    {
        Id = 2,
        FirstName = "Nurullo",
        LastName = "Sulaymonov",
        Age = 30,
        PhoneNumber = "908765432",
        Salary = 8000m
    },
    new Employee
    {
        Id = 3,
        FirstName = "Shodmon",
        LastName = "Inoyatzoda",
        Age = 26,
        PhoneNumber = "987009988",
        Salary = 7800m
    }
};

PrintEmployees("Section 2 - initial employees", employees);

List<Employee> extraEmployees = new List<Employee>
{
    new Employee
    {
        Id = 4,
        FirstName = "Abduazim",
        LastName = "Sharipov",
        Age = 22,
        PhoneNumber = "920001122",
        Salary = 4200m
    },
    new Employee
    {
        Id = 5,
        FirstName = "Dilshod",
        LastName = "Rajabov",
        Age = 35,
        PhoneNumber = "936664455",
        Salary = 9800m
    }
};

employees.AddRange(extraEmployees);
PrintEmployees("Section 3 - after AddRange", employees);

employees = employees.OrderBy(employee => employee.Salary).ToList();
PrintEmployees("Section 4 - sorted by salary ascending", employees);

employees.RemoveAll(employee => employee.Age < 25);
PrintEmployees("Section 5 - after RemoveAll(age < 25)", employees);

List<Employee> highSalaryEmployees = employees.FindAll(employee => employee.Salary > 5000m);
PrintEmployees("Section 6 - employees with salary > 5000", highSalaryEmployees);

Employee? employeeWithId3 = employees.FirstOrDefault(employee => employee.Id == 3);
if (employeeWithId3 != null)
{
    employees.Remove(employeeWithId3);
}
PrintEmployees("Section 7 - after removing employee with Id 3", employees);

bool hasJura = employees.Exists(employee =>
    employee.FirstName.Equals("Jura", StringComparison.OrdinalIgnoreCase));

if (!hasJura)
{
    Employee jura = new Employee("Jura", "Karimov")
    {
        Id = 6,
        Age = 28,
        PhoneNumber = "901112233",
        Salary = 6500m
    };

    int insertIndex = employees.Count >= 1 ? 1 : 0;
    employees.Insert(insertIndex, jura);
}
PrintEmployees("Section 8 - after Exists/Insert", employees);

List<Employee> insertedEmployees = new List<Employee>
{
    new Employee
    {
        Id = 7,
        FirstName = "Said",
        LastName = "Nazarov",
        Age = 29,
        PhoneNumber = "915557788",
        Salary = 7000m
    },
    new Employee
    {
        Id = 8,
        FirstName = "Farzona",
        LastName = "Ibrohimova",
        Age = 27,
        PhoneNumber = "937777999",
        Salary = 7200m
    },
    new Employee
    {
        Id = 9,
        FirstName = "Komron",
        LastName = "Habibov",
        Age = 31,
        PhoneNumber = "911223344",
        Salary = 7600m
    }
};

int insertRangeIndex = employees.Count >= 2 ? 2 : employees.Count;
employees.InsertRange(insertRangeIndex, insertedEmployees);
PrintEmployees("Section 9 - after InsertRange", employees);

employees = employees.OrderByDescending(employee => employee.Salary).ToList();
PrintEmployees("Section 10 - sorted by salary descending", employees);

static void PrintEmployees(string title, List<Employee> employees)
{
    Console.WriteLine();
    Console.WriteLine(title);

    if (employees.Count == 0)
    {
        Console.WriteLine("No employees");
        return;
    }

    foreach (Employee employee in employees)
    {
        Console.WriteLine(
            $"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}, Age: {employee.Age}, Salary: {employee.Salary}, BirthYear: {employee.GetBirthYear()}");
    }
}

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public decimal Salary { get; set; }

    public Employee()
    {
    }

    public Employee(string name, string surname)
    {
        FirstName = name;
        LastName = surname;
    }

    public int GetBirthYear()
    {
        return DateTime.Now.Year - Age;
    }
}
