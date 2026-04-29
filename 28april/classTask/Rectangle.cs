public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
        : base("Rectangle shape")
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }

    public override void PrintDescription()
    {
        Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}");
    }
}
