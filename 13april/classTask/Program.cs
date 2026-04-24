// task1
// Person person = new Person();
// Console.Write("Enter your FirstName : ");
// person.FirstName = Console.ReadLine() ?? "";
// Console.Write("Enter your LastName : ");
// person.LastName = Console.ReadLine() ?? "";
// Console.Write("Enter your Age : ");
// person.Age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(person.GetInfo());

// task2
// Post post = new Post();
// post.SetPost("It is Post");
// post.AddLike();
// post.AddLike();
// post.AddComment("Super");
// post.AddComment("Great");
// Console.WriteLine(post.GetInfo());

// task3
// Player player = new Player();
// Console.Write("Enter player's name: ");
// player.Name = Console.ReadLine() ?? "";
// Console.Write("Enter player's number: ");
// player.Number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter player's position: ");
// player.Position = Console.ReadLine() ?? "";
// Console.Write("Enter player's team: ");
// player.Team = Console.ReadLine() ?? "";
// Console.WriteLine();
// Console.WriteLine(player.GetInfo());
// player.ScoreGoal();
// player.AssistGoal("Neymar");

// task4
// Employee employee = new Employee();
// Console.Write("Enter employee's FirstName: ");
// employee.FirstName = Console.ReadLine() ?? "";
// Console.Write("Enter employee's LastName: ");
// employee.LastName = Console.ReadLine() ?? "";
// Console.Write("Enter employee's Age: ");
// employee.Age = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter employee's Position: ");
// employee.Position = Console.ReadLine() ?? "";
// Console.Write("Enter employee's Salary: ");
// employee.SetSalary(Convert.ToDecimal(Console.ReadLine()));
// Console.WriteLine();
// Console.WriteLine(employee.GetInfo());
// Console.Write("Set a new Salary: ");
// employee.SetSalary(Convert.ToDecimal(Console.ReadLine()));
// Console.WriteLine();
// Console.WriteLine(employee.GetInfo());

public class Program
{
    public static void Main()
    {
    }
}

class Person
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int Age { get; set; }

    public string GetInfo()
    {
        return $"FirstName: {FirstName}\nLastName: {LastName}\nAge: {Age}";
    }
}

class Post
{
    public string Text { get; set; } = "";
    public int Likes { get; set; }
    public List<string> Comments { get; set; } = new List<string>();

    public void SetPost(string text)
    {
        Text = text;
    }

    public void AddLike()
    {
        Likes++;
    }

    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }

    public string GetInfo()
    {
        string result = $"Text = {Text}\nLikes : {Likes}\n\nComments : ";

        if (Comments.Count == 0)
        {
            return result + "\nNo comments";
        }

        foreach (string comment in Comments)
        {
            result += "\n" + comment;
        }

        return result;
    }
}

class Player
{
    public string Name { get; set; } = "";
    public int Number { get; set; }
    public string Position { get; set; } = "";
    public string Team { get; set; } = "";

    public void ScoreGoal()
    {
        Console.WriteLine($"{Name} scores a goal!");
    }

    public void AssistGoal(string playerName)
    {
        Console.WriteLine($"{Name} assists a goal for {playerName}.");
    }

    public string GetInfo()
    {
        return $"Name: {Name}\nNumber: {Number}\nPosition: {Position}\nTeam: {Team}";
    }
}

class Employee
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public int Age { get; set; }
    public string Position { get; set; } = "";
    public decimal Salary { get; set; }

    public void SetSalary(decimal salary)
    {
        Salary = salary;
    }

    public decimal GetSalary()
    {
        return Salary;
    }

    public string GetInfo()
    {
        return $"FirstName: {FirstName}\nLastName: {LastName}\nAge: {Age}\nPosition: {Position}\nSalary: {Salary:0.0}";
    }
}
