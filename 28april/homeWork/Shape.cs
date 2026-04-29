public class Shape
{
    private string color;

    public Shape(string color)
    {
        this.color = color;
    }

    protected string GetColor()
    {
        return color;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Shape color: {color}");
    }
}
