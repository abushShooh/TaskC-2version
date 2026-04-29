PrintTitle("Task 1");

Shape rectangle = new Rectangle(5, 4);
Shape circle = new Circle(3);

rectangle.PrintDescription();
Console.WriteLine($"Area: {rectangle.CalculateArea():F2}");

Console.WriteLine();

circle.PrintDescription();
Console.WriteLine($"Area: {circle.CalculateArea():F2}");

PrintTitle("Task 2");

IMovable car = new Car("Toyota Camry");
car.MoveLeft();
car.MoveRight();

PrintTitle("Task 3");

BankAccount bankAccount = new BankAccount(1001, "Abubakr", 500m);
bankAccount.PrintStatement();

bankAccount.TopUp(250m);
bankAccount.Withdraw(100m);
bankAccount.Withdraw(1000m);

Console.WriteLine();
bankAccount.PrintStatement();

PrintTitle("Task 4");

Library library = new Library("Central Library");

Book firstBook = new Book("Clean Code", "Robert Martin", 2008);
Book secondBook = new Book("The Hobbit", "J.R.R. Tolkien", 1937);
Book thirdBook = new Book("C# in Depth", "Jon Skeet", 2019);

library.AddBook(firstBook);
library.AddBook(secondBook);
library.AddBook(thirdBook);

Console.WriteLine();
ShowBooks(library);

Console.WriteLine();
Book? foundBook = library.SearchBook("The Hobbit");

if (foundBook != null)
{
    Console.WriteLine($"Found book: {foundBook.Title} - {foundBook.Author} - {foundBook.PublicationYear}");
}
else
{
    Console.WriteLine("Book not found.");
}

Console.WriteLine();
library.RemoveBook(secondBook);
ShowBooks(library);

static void PrintTitle(string title)
{
    Console.WriteLine();
    Console.WriteLine("===== " + title + " =====");
}

static void ShowBooks(Library library)
{
    Console.WriteLine($"Library: {library.Name}");

    foreach (Book book in library.Books)
    {
        Console.WriteLine($"{book.Title} - {book.Author} - {book.PublicationYear}");
    }
}
