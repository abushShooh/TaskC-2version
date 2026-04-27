public class Book : AbstractBook, Borrowable
{
    public void Borrow()
    {
        Console.WriteLine($"Book \"{GetTitle()}\" has been borrowed.");
    }

    public void ReturnBook()
    {
        Console.WriteLine($"Book \"{GetTitle()}\" has been returned.");
    }
}
