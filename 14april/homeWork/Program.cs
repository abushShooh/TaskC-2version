_ = 0;

// task1
// Rectangle rectangle = new Rectangle(7, 5, "Red");
// Console.WriteLine($"Width: {rectangle.Width}");
// Console.WriteLine($"Height: {rectangle.Height}");
// Console.WriteLine($"Color: {rectangle.Color}");
// Console.WriteLine($"Area: {rectangle.GetArea()}");
// Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");

// task2
// User user = new User("Ivan", "Ivanov", "ivan123", "12345");
// Console.WriteLine(user.GetFullInfo());
// user.Login("ivan123", "12345");
// Console.WriteLine(user.GetFullInfo());
// user.ChangePassword("12345", "54321");
// user.Logout();
// Console.WriteLine($"Account age in days: {user.GetAccountAgeInDays()}");

// task3
// Author author = new Author("Alexander Pushkin", 37, "Russian");
// Book book1 = new Book("Eugene Onegin", "Novel", 224);
// Book book2 = new Book("The Captain's Daughter", "Historical novel", 160);
// author.Introduce();
// author.AddBook(book1);
// author.AddBook(book2);
// foreach (Book book in author.ListBooks())
// {
//     Console.WriteLine(book.GetInfo());
// }
// author.CelebrateBirthday();
// Console.WriteLine($"New age: {author.GetAge()}");

// task4
// Country country = new Country("Uzbekistan", "Tashkent", 38000000, "Uzbek");
// Console.WriteLine($"Country Name: {country.GetName()}");
// Console.WriteLine($"Capital: {country.GetCapital()}");
// Console.WriteLine($"Population: {country.GetPopulation()}");
// Console.WriteLine($"Official Language: {country.GetOfficialLanguage()}");

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public string Color { get; set; }

    public Rectangle(int width, int height, string color)
    {
        Width = width;
        Height = height;
        Color = color;
    }

    public int GetArea()
    {
        return Width * Height;
    }

    public int GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public bool IsLoggedIn { get; set; }
    public DateTime CreatedAt { get; set; }

    public User(string firstName, string lastName, string username, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Username = username;
        PasswordHash = HashPassword(password);
        IsLoggedIn = false;
        CreatedAt = DateTime.Now;
    }

    private string HashPassword(string password)
    {
        return "hash_" + password.Length + "_" + password.ToUpper();
    }

    public void Login(string username, string password)
    {
        if (Username == username && PasswordHash == HashPassword(password))
        {
            IsLoggedIn = true;
            Console.WriteLine($"Добро пожаловать, {FirstName}!");
        }
        else
        {
            Console.WriteLine("Ошибка входа: проверьте логин или пароль.");
        }
    }

    public void Logout()
    {
        IsLoggedIn = false;
        Console.WriteLine("Вы вышли из системы.");
    }

    public string GetFullInfo()
    {
        return $"{FirstName} {LastName} | Логин: {Username} | Онлайн: {IsLoggedIn.ToString().ToLower()}";
    }

    public void ChangePassword(string oldPassword, string newPassword)
    {
        if (PasswordHash == HashPassword(oldPassword))
        {
            PasswordHash = HashPassword(newPassword);
            Console.WriteLine("Пароль успешно изменён.");
        }
        else
        {
            Console.WriteLine("Старый пароль введён неверно.");
        }
    }

    public int GetAccountAgeInDays()
    {
        return (DateTime.Now - CreatedAt).Days;
    }
}

public class Author
{
    private string name;
    private int age;
    private string nationality;
    private List<Book> books;

    public Author()
    {
        name = "Unknown";
        age = 0;
        nationality = "Unknown";
        books = new List<Book>();
    }

    public Author(string name, int age)
    {
        this.name = name;
        this.age = age;
        nationality = "Unknown";
        books = new List<Book>();
    }

    public Author(string name, int age, string nationality)
    {
        this.name = name;
        this.age = age;
        this.nationality = nationality;
        books = new List<Book>();
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public string GetNationality()
    {
        return nationality;
    }

    public void Introduce()
    {
        Console.WriteLine($"Меня зовут {name}. Мне {age} лет. Я из {nationality}.");
    }

    public void CelebrateBirthday()
    {
        age++;
    }

    public void AddBook(Book book)
    {
        if (book != null)
        {
            books.Add(book);
        }
    }

    public List<Book> ListBooks()
    {
        return new List<Book>(books);
    }
}

public class Book
{
    private string title;
    private string genre;
    private int pages;

    public Book(string title, string genre, int pages)
    {
        this.title = title;
        this.genre = genre;
        this.pages = pages;
    }

    public string GetInfo()
    {
        return $"Книга: {title}, Жанр: {genre}, Страниц: {pages}";
    }
}

public class Country
{
    private string name;
    private string capital;
    private int population;
    private string officialLanguage;

    public Country(string name, string capital, int population, string officialLanguage)
    {
        this.name = name;
        this.capital = capital;
        this.population = population;
        this.officialLanguage = officialLanguage;
    }

    public string GetName()
    {
        return name;
    }

    public void SetCapital(string capital)
    {
        this.capital = capital;
    }

    public string GetCapital()
    {
        return capital;
    }

    public void SetPopulation(int population)
    {
        this.population = population;
    }

    public int GetPopulation()
    {
        return population;
    }

    public void SetOfficialLanguage(string language)
    {
        officialLanguage = language;
    }

    public string GetOfficialLanguage()
    {
        return officialLanguage;
    }
}
