using Domain.Models;

namespace Infrastructure.Services;

public class TeacherService
{
    private readonly List<Teacher> teachers = new();

    public List<Teacher> GetTeacher()
    {
        return teachers;
    }

    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }

    public void UpdateTeacher(Teacher teacher)
    {
        Teacher? foundTeacher = teachers.FirstOrDefault(t => t.Id == teacher.Id);

        if (foundTeacher != null)
        {
            foundTeacher.Firstname = teacher.Firstname;
            foundTeacher.Lastname = teacher.Lastname;
            foundTeacher.Position = teacher.Position;
            foundTeacher.ExperienceAmount = teacher.ExperienceAmount;
        }
    }

    public void Delete(int id)
    {
        Teacher? foundTeacher = teachers.FirstOrDefault(t => t.Id == id);

        if (foundTeacher != null)
        {
            teachers.Remove(foundTeacher);
        }
    }
}
