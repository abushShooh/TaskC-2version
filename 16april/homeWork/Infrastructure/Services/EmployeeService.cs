using Domain.Models;

namespace Infrastructure.Services;

public class EmployeeService
{
    private readonly List<Employee> employees = new();

    public List<Employee> GetEmployees()
    {
        return employees;
    }

    public void AddEmployees(Employee employee)
    {
        employees.Add(employee);
    }

    public int CountEmployees()
    {
        return employees.Count;
    }
}
