List<Person> people = new List<Person>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Person {i + 1}:");

    Console.Write("Name: ");
    string name = Console.ReadLine() ?? string.Empty;

    Console.Write("Surname: ");
    string surname = Console.ReadLine() ?? string.Empty;

    Console.Write("Age: ");
    int age = int.Parse(Console.ReadLine() ?? "0");

    Person person = new Person
    {
        Id = i + 1,
        Name = name,
        Surname = surname,
        Age = age
    };

    people.Add(person);
    Console.WriteLine("-------------------------");
}

foreach (Person person in people)
{
    Console.WriteLine(person.GetInfo());
}
