public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string GetInfo()
    {
        return $"{Id} - {Name}";
    }
}
