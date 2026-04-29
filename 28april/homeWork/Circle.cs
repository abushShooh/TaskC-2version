public class Circle : Shape
{
    private double radius;

    public Circle(string color, double radius)
        : base(color)
    {
        this.radius = radius;
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Circle");
        Console.WriteLine($"Color: {GetColor()}");
        Console.WriteLine($"Radius: {radius}");
    }
}
