using Domain.Models;

namespace Infrastructure.Services;

public class StudentService
{
    private readonly List<Student> students = new();

    public List<Student> GetStudents()
    {
        return students;
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void UpdateStudent(Student student)
    {
        Student? foundStudent = students.FirstOrDefault(s => s.Id == student.Id);

        if (foundStudent != null)
        {
            foundStudent.Firstname = student.Firstname;
            foundStudent.Lastname = student.Lastname;
            foundStudent.BirthDate = student.BirthDate;
            foundStudent.Address = student.Address;
        }
    }

    public void Delete(int id)
    {
        Student? foundStudent = students.FirstOrDefault(s => s.Id == id);

        if (foundStudent != null)
        {
            students.Remove(foundStudent);
        }
    }
}
