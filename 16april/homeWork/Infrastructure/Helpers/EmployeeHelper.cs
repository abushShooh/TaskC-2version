using Domain.Models;

namespace Infrastructure.Helpers;

public static class EmployeeHelper
{
    public static string GetFullName(Employee employee)
    {
        return $"{employee.Firstname} {employee.Lastname}";
    }

    public static int GetAge(Employee employee)
    {
        int age = DateTime.Now.Year - employee.BirthDate.Year;

        if (employee.BirthDate.Date > DateTime.Now.AddYears(-age))
        {
            age--;
        }

        return age;
    }
}
