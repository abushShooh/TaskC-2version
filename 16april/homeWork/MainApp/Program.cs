using Domain.Models;
using Infrastructure.Helpers;
using Infrastructure.Services;

EmployeeService employeeService = new EmployeeService();
DepartmentService departmentService = new DepartmentService();

Employee manager = new Employee
{
    Firstname = "Shahrom",
    Lastname = "Sharipov",
    BirthDate = new DateTime(2000, 5, 15),
    Salary = 5500
};

Department department = new Department
{
    Name = "IT",
    Description = "Software development department",
    Manager = manager
};

manager.Department = department;

Employee employee = new Employee
{
    Firstname = "Ali",
    Lastname = "Karimov",
    BirthDate = new DateTime(2002, 8, 10),
    Salary = 3200,
    Department = department
};

departmentService.AddDepartments(department);
employeeService.AddEmployees(manager);
employeeService.AddEmployees(employee);

Console.WriteLine("Departments:");
foreach (Department item in departmentService.GetDepartments())
{
    Console.WriteLine($"Name: {item.Name}");
    Console.WriteLine($"Description: {item.Description}");
    Console.WriteLine($"Manager: {EmployeeHelper.GetFullName(item.Manager)}");
    Console.WriteLine();
}

Console.WriteLine("Employees:");
foreach (Employee item in employeeService.GetEmployees())
{
    Console.WriteLine($"Full name: {EmployeeHelper.GetFullName(item)}");
    Console.WriteLine($"Age: {EmployeeHelper.GetAge(item)}");
    Console.WriteLine($"Salary: {item.Salary}");
    Console.WriteLine($"Department: {item.Department.Name}");
    Console.WriteLine();
}

Console.WriteLine($"Departments count: {departmentService.CountDepartments()}");
Console.WriteLine($"Employees count: {employeeService.CountEmployees()}");
