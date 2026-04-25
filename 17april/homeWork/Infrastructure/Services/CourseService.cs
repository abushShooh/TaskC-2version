using Domain.Models;

namespace Infrastructure.Services;

public class CourseService
{
    private readonly List<Course> courses = new();

    public List<Course> GetCourses()
    {
        return courses;
    }

    public void AddCourses(Course course)
    {
        courses.Add(course);
    }

    public void UpdateStudent(Course course)
    {
        Course? foundCourse = courses.FirstOrDefault(c => c.Id == course.Id);

        if (foundCourse != null)
        {
            foundCourse.Title = course.Title;
            foundCourse.Description = course.Description;
            foundCourse.Fee = course.Fee;
            foundCourse.HasDiscount = course.HasDiscount;
        }
    }

    public void Delete(int id)
    {
        Course? foundCourse = courses.FirstOrDefault(c => c.Id == id);

        if (foundCourse != null)
        {
            courses.Remove(foundCourse);
        }
    }
}
