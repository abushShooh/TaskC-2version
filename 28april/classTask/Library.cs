public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added.");
    }

    public void RemoveBook(Book book)
    {
        bool removed = Books.Remove(book);

        if (removed)
        {
            Console.WriteLine($"Book '{book.Title}' removed.");
        }
        else
        {
            Console.WriteLine("Book not found for remove.");
        }
    }

    public Book? SearchBook(string title)
    {
        return Books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }
}
