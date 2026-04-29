public class Lamp : IDevice
{
    public string Location { get; set; }
    public int Brightness { get; private set; }

    public Lamp(string location)
    {
        Location = location;
    }

    public void TurnOn()
    {
        Console.WriteLine($"Lamp in {Location} is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine($"Lamp in {Location} is turned off.");
    }

    public void SetBrightness(int brightness)
    {
        if (brightness < 0 || brightness > 100)
        {
            Console.WriteLine("Brightness must be from 0 to 100.");
            return;
        }

        Brightness = brightness;
        Console.WriteLine($"Lamp brightness set to {Brightness}%.");
    }
}
