namespace Domain.Models;

public class Teacher
{
    public int Id { get; set; }
    public string Firstname { get; set; } = string.Empty;
    public string Lastname { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public int ExperienceAmount { get; set; }
}
