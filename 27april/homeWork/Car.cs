public class Car : IVehicle
{
    private int gasoline;

    public Car(int gasoline)
    {
        this.gasoline = gasoline;
    }

    public void Drive()
    {
        if (gasoline > 0)
        {
            Console.WriteLine("Driving");
        }
        else
        {
            Console.WriteLine("No gasoline.");
        }
    }

    public bool Refuel(int amount)
    {
        if (amount <= 0)
        {
            return false;
        }

        gasoline += amount;
        return true;
    }
}
