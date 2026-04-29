public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
        : base("Circle shape")
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void PrintDescription()
    {
        Console.WriteLine($"Circle: Radius = {Radius}");
    }
}
