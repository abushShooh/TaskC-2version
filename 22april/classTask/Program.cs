Shop shop = new Shop();

Phone phone1 = new Phone("iPhone 15", 1200m, "Apple", 256);
Phone phone2 = new Phone("Galaxy S24", 1100m, "Samsung", 512);
Car car1 = new Car("Corolla", 22000m, "Toyota", 150);
Car car2 = new Car("Camry", 30000m, "Toyota", 200);

shop.AddProduct(phone1);
shop.AddProduct(phone2);
shop.AddProduct(car1);
shop.AddProduct(car2);

Console.WriteLine("Initial product list:");
shop.PrintProductList();

Product newProduct = new Phone("Redmi Note 13", 350m, "Xiaomi", 128);
shop.AddProduct(newProduct);

Console.WriteLine();
Console.WriteLine("After adding new product:");
shop.PrintProductList();

shop.RemoveProduct(car1);

Console.WriteLine();
Console.WriteLine("After removing one product:");
shop.PrintProductList();

public class Shop
{
    public List<Product> Products { get; set; } = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        Products.Remove(product);
    }

    public void PrintProductList()
    {
        foreach (Product product in Products)
        {
            product.PrintInfo();
        }
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price}");
    }
}

public class Phone : Product
{
    public string Brand { get; set; }
    public int Memory { get; set; }

    public Phone(string name, decimal price, string brand, int memory) : base(name, price)
    {
        Brand = brand;
        Memory = memory;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Phone: {Name}, Price: {Price}, Brand: {Brand}, Memory: {Memory}GB");
    }
}

public class Car : Product
{
    public string Model { get; set; }
    public int HorsePower { get; set; }

    public Car(string name, decimal price, string model, int horsePower) : base(name, price)
    {
        Model = model;
        HorsePower = horsePower;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Car: {Name}, Price: {Price}, Model: {Model}, HorsePower: {HorsePower}");
    }
}
