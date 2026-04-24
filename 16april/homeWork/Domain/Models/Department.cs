namespace Domain.Models;

public class Department
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Employee Manager { get; set; } = null!;
}
