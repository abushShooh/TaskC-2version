Console.WriteLine("Task 1");

Laptop laptop = new Laptop(ram: 16, storage: 512, keyboard: true, weight: 2.1);
laptop.AddRam(8);
laptop.AddStorage(512);
laptop.WeightCheck();
laptop.PrintInfo();

Console.WriteLine();

SmartPhone smartPhone = new SmartPhone(ram: 8, storage: 256, keyboard: false, numberOfSelfies: 120);
smartPhone.TakeSelfies(15);
smartPhone.AddStorage(128);
smartPhone.PrintInfo();

Console.WriteLine();
Console.WriteLine("Task 2");

PassengerCar passengerCar = new PassengerCar(
    name: "Toyota Camry",
    maxSpeed: 220,
    capacity: 5,
    fuelType: "Petrol",
    passengerSeats: 5);

CargoCar cargoCar = new CargoCar(
    name: "Volvo Truck",
    maxSpeed: 140,
    capacity: 2,
    fuelType: "Diesel",
    cargoWeightKg: 18000);

PassengerPlane passengerPlane = new PassengerPlane(
    name: "Airbus A320",
    maxSpeed: 870,
    capacity: 180,
    maxAltitude: 12000,
    passengerCount: 170);

CargoPlane cargoPlane = new CargoPlane(
    name: "Boeing 747 Cargo",
    maxSpeed: 900,
    capacity: 6,
    maxAltitude: 13000,
    cargoVolume: 700);

Train train = new Train(
    name: "Intercity",
    maxSpeed: 180,
    capacity: 500,
    wagons: 10);

List<Transport> transports = new List<Transport>
{
    passengerCar,
    cargoCar,
    passengerPlane,
    cargoPlane,
    train
};

foreach (Transport transport in transports)
{
    transport.PrintInfo();
    Console.WriteLine();
}

public class Computer
{
    public int Ram { get; set; }
    public int Storage { get; set; }
    public bool Keyboard { get; set; }

    public Computer(int ram, int storage, bool keyboard)
    {
        Ram = ram;
        Storage = storage;
        Keyboard = keyboard;
    }

    public void AddRam(int amount)
    {
        Ram += amount;
    }

    public void AddStorage(int amount)
    {
        Storage += amount;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Ram: {Ram} GB");
        Console.WriteLine($"Storage: {Storage} GB");
        Console.WriteLine($"Keyboard: {Keyboard}");
    }
}

public class Laptop : Computer
{
    public double Weight { get; set; }

    public Laptop(int ram, int storage, bool keyboard, double weight) : base(ram, storage, keyboard)
    {
        Weight = weight;
    }

    public void WeightCheck()
    {
        Console.WriteLine($"Weight check: {Weight} kg");
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Laptop");
        base.PrintInfo();
        Console.WriteLine($"Weight: {Weight} kg");
    }
}

public class SmartPhone : Computer
{
    public int NumberOfSelfies { get; set; }

    public SmartPhone(int ram, int storage, bool keyboard, int numberOfSelfies) : base(ram, storage, keyboard)
    {
        NumberOfSelfies = numberOfSelfies;
    }

    public void TakeSelfies(int count)
    {
        NumberOfSelfies += count;
    }

    public override void PrintInfo()
    {
        Console.WriteLine("SmartPhone");
        base.PrintInfo();
        Console.WriteLine($"Number of selfies: {NumberOfSelfies}");
    }
}

public class Transport
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }
    public int Capacity { get; set; }

    public Transport(string name, int maxSpeed, int capacity)
    {
        Name = name;
        MaxSpeed = maxSpeed;
        Capacity = capacity;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Type: {GetType().Name}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Max speed: {MaxSpeed} km/h");
        Console.WriteLine($"Capacity: {Capacity}");
    }
}

public class Car : Transport
{
    public string FuelType { get; set; }

    public Car(string name, int maxSpeed, int capacity, string fuelType) : base(name, maxSpeed, capacity)
    {
        FuelType = fuelType;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Fuel type: {FuelType}");
    }
}

public class PassengerCar : Car
{
    public int PassengerSeats { get; set; }

    public PassengerCar(string name, int maxSpeed, int capacity, string fuelType, int passengerSeats)
        : base(name, maxSpeed, capacity, fuelType)
    {
        PassengerSeats = passengerSeats;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Passenger seats: {PassengerSeats}");
    }
}

public class CargoCar : Car
{
    public int CargoWeightKg { get; set; }

    public CargoCar(string name, int maxSpeed, int capacity, string fuelType, int cargoWeightKg)
        : base(name, maxSpeed, capacity, fuelType)
    {
        CargoWeightKg = cargoWeightKg;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Cargo weight: {CargoWeightKg} kg");
    }
}

public class Airplane : Transport
{
    public int MaxAltitude { get; set; }

    public Airplane(string name, int maxSpeed, int capacity, int maxAltitude) : base(name, maxSpeed, capacity)
    {
        MaxAltitude = maxAltitude;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Max altitude: {MaxAltitude} m");
    }
}

public class CargoPlane : Airplane
{
    public int CargoVolume { get; set; }

    public CargoPlane(string name, int maxSpeed, int capacity, int maxAltitude, int cargoVolume)
        : base(name, maxSpeed, capacity, maxAltitude)
    {
        CargoVolume = cargoVolume;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Cargo volume: {CargoVolume} m3");
    }
}

public class PassengerPlane : Airplane
{
    public int PassengerCount { get; set; }

    public PassengerPlane(string name, int maxSpeed, int capacity, int maxAltitude, int passengerCount)
        : base(name, maxSpeed, capacity, maxAltitude)
    {
        PassengerCount = passengerCount;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Passenger count: {PassengerCount}");
    }
}

public class Train : Transport
{
    public int Wagons { get; set; }

    public Train(string name, int maxSpeed, int capacity, int wagons) : base(name, maxSpeed, capacity)
    {
        Wagons = wagons;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Wagons: {Wagons}");
    }
}
