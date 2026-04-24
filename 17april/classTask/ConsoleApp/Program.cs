using Domain.Model;
using Infrastructure.Services;

StudentService studentService = new StudentService();

Student firstStudent = new Student
{
    Id = 1,
    Name = "Shahrom",
    Age = 24
};

Student secondStudent = new Student
{
    Id = 2,
    Name = "Abdulloh",
    Age = 27
};

studentService.CreateStudent(firstStudent);
studentService.CreateStudent(secondStudent);

Console.WriteLine("Students after create:");
ShowStudents(studentService.GetStudents());

Student updatedStudent = new Student
{
    Id = 2,
    Name = "Abdulloh Updated",
    Age = 28
};

studentService.UpdateStudent(updatedStudent);

Console.WriteLine();
Console.WriteLine("Students after update:");
ShowStudents(studentService.GetStudents());

studentService.DeleteStudent(1);

Console.WriteLine();
Console.WriteLine("Students after delete:");
ShowStudents(studentService.GetStudents());

static void ShowStudents(List<Student> students)
{
    foreach (Student student in students)
    {
        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
    }
}
