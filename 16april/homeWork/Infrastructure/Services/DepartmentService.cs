using Domain.Models;

namespace Infrastructure.Services;

public class DepartmentService
{
    private readonly List<Department> departments = new();

    public List<Department> GetDepartments()
    {
        return departments;
    }

    public void AddDepartments(Department department)
    {
        departments.Add(department);
    }

    public int CountDepartments()
    {
        return departments.Count;
    }
}
