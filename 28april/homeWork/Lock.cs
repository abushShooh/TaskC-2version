public class Lock : IDevice
{
    public string DoorName { get; set; }
    public bool IsLocked { get; private set; }

    public Lock(string doorName)
    {
        DoorName = doorName;
    }

    public void TurnOn()
    {
        Console.WriteLine($"{DoorName} lock system is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine($"{DoorName} lock system is turned off.");
    }

    public void LockDoor()
    {
        IsLocked = true;
        Console.WriteLine($"{DoorName} is locked.");
    }

    public void UnlockDoor()
    {
        IsLocked = false;
        Console.WriteLine($"{DoorName} is unlocked.");
    }
}
