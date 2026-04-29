public class Thermostat : IDevice
{
    public string Room { get; set; }
    public double Temperature { get; private set; }

    public Thermostat(string room)
    {
        Room = room;
    }

    public void TurnOn()
    {
        Console.WriteLine($"Thermostat in {Room} is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine($"Thermostat in {Room} is turned off.");
    }

    public void SetTemperature(double temperature)
    {
        Temperature = temperature;
        Console.WriteLine($"Temperature in {Room} set to {Temperature}C.");
    }
}
