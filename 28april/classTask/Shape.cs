public abstract class Shape
{
    public string Description { get; set; }

    protected Shape(string description)
    {
        Description = description;
    }

    public abstract double CalculateArea();

    public virtual void PrintDescription()
    {
        Console.WriteLine(Description);
    }
}
