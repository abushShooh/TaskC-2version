using Domain.Model;

namespace Infrastructure.Services;

public class StudentService
{
    private readonly List<Student> students = new();

    public void CreateStudent(Student student)
    {
        students.Add(student);
    }

    public List<Student> GetStudents()
    {
        return students;
    }

    public void UpdateStudent(Student student)
    {
        Student? foundStudent = students.FirstOrDefault(s => s.Id == student.Id);

        if (foundStudent != null)
        {
            foundStudent.Name = student.Name;
            foundStudent.Age = student.Age;
        }
    }

    public void DeleteStudent(int id)
    {
        Student? foundStudent = students.FirstOrDefault(s => s.Id == id);

        if (foundStudent != null)
        {
            students.Remove(foundStudent);
        }
    }
}
