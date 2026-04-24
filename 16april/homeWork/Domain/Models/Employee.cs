namespace Domain.Models;

public class Employee
{
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public decimal Salary { get; set; }
    public Department Department { get; set; } = null!;
}
