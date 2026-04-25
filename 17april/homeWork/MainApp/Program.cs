using Domain.Models;
using Infrastructure.Helpers;
using Infrastructure.Services;

StudentService studentService = new StudentService();
TeacherService teacherService = new TeacherService();
CourseService courseService = new CourseService();
PostService postService = new PostService();

studentService.AddStudent(new Student
{
    Id = 1,
    Firstname = "Shahrom",
    Lastname = "Sharipov",
    BirthDate = new DateTime(2000, 5, 1),
    Address = "Dushanbe"
});

teacherService.AddTeacher(new Teacher
{
    Id = 1,
    Firstname = "Abdulloh",
    Lastname = "Karimov",
    Position = "Senior Teacher",
    ExperienceAmount = 6
});

courseService.AddCourses(new Course
{
    Id = 1,
    Title = "C# Basics",
    Description = "Beginner course",
    Fee = 1200,
    HasDiscount = true
});

postService.AddPost(new Post
{
    Id = 1,
    Title = "Lesson 1",
    Description = "Introduction to OOP",
    VoteAmount = 12,
    CreatedAt = DateTime.Now
});

studentService.UpdateStudent(new Student
{
    Id = 1,
    Firstname = "Shahromjon",
    Lastname = "Sharipov",
    BirthDate = new DateTime(2000, 5, 1),
    Address = "Khujand"
});

teacherService.UpdateTeacher(new Teacher
{
    Id = 1,
    Firstname = "Abdulloh",
    Lastname = "Karimov",
    Position = "Lead Teacher",
    ExperienceAmount = 7
});

courseService.UpdateStudent(new Course
{
    Id = 1,
    Title = "C# From Zero",
    Description = "Updated beginner course",
    Fee = 1500,
    HasDiscount = false
});

postService.UpdatePost(new Post
{
    Id = 1,
    Title = "Lesson 1 Updated",
    Description = "OOP and classes",
    VoteAmount = 20,
    CreatedAt = DateTime.Now
});

ConsoleSectionHelper.PrintTitle("Students");
foreach (Student student in studentService.GetStudents())
{
    Console.WriteLine($"{student.Id} | {student.Firstname} {student.Lastname} | {student.Address}");
}

ConsoleSectionHelper.PrintTitle("Teachers");
foreach (Teacher teacher in teacherService.GetTeacher())
{
    Console.WriteLine($"{teacher.Id} | {teacher.Firstname} {teacher.Lastname} | {teacher.Position}");
}

ConsoleSectionHelper.PrintTitle("Courses");
foreach (Course course in courseService.GetCourses())
{
    Console.WriteLine($"{course.Id} | {course.Title} | Fee: {course.Fee}");
}

ConsoleSectionHelper.PrintTitle("Posts");
foreach (Post post in postService.GetPosts())
{
    Console.WriteLine($"{post.Id} | {post.Title} | Votes: {post.VoteAmount}");
}
