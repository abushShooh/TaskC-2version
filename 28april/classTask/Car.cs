public class Car : IMovable
{
    public string Model { get; set; }

    public Car(string model)
    {
        Model = model;
    }

    public void MoveLeft()
    {
        Console.WriteLine($"{Model} is moving left.");
    }

    public void MoveRight()
    {
        Console.WriteLine($"{Model} is moving right.");
    }
}
