// Task 1
List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };
int sum1 = numbers1.Sum();
PrintTitle("Task 1");
Console.WriteLine($"Sum: {sum1}");

// Task 2
List<string> lines2 = new List<string> { "apple", "kiwi", "watermelon", "pear" };
lines2.Sort((first, second) => second.Length.CompareTo(first.Length));
PrintTitle("Task 2");
foreach (string line in lines2)
{
    Console.WriteLine(line);
}

// Task 3
List<Person> people3 = new List<Person>
{
    new Person { Name = "Ali", Age = 23, City = "Dushanbe" },
    new Person { Name = "Zarina", Age = 19, City = "Khujand" },
    new Person { Name = "Bek", Age = 28, City = "Dushanbe" }
};
people3.Sort((first, second) => first.Age.CompareTo(second.Age));
PrintTitle("Task 3");
foreach (Person person in people3)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}

// Task 4
List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
numbers4.RemoveAll(number => number % 2 != 0);
PrintTitle("Task 4");
Console.WriteLine(string.Join(", ", numbers4));

// Task 5
List<string> lines5 = new List<string> { "hello", "world", "csharp" };
List<string> upperLines = lines5.Select(line => line.ToUpper()).ToList();
PrintTitle("Task 5");
foreach (string line in upperLines)
{
    Console.WriteLine(line);
}

// Task 6
List<int> numbers6 = new List<int> { 12, 3, 55, 7, 20 };
int maxValue = numbers6.Max();
int minValue = numbers6.Min();
PrintTitle("Task 6");
Console.WriteLine($"Max: {maxValue}");
Console.WriteLine($"Min: {minValue}");

// Task 7
List<string> lines7 = new List<string> { "abc", "apple", "qwerty", "moon" };
PrintTitle("Task 7");
foreach (string line in lines7)
{
    bool hasOnlyUniqueChars = new HashSet<char>(line).Count == line.Length;
    Console.WriteLine($"{line} -> {hasOnlyUniqueChars}");
}

// Task 8
List<Person> people8 = new List<Person>
{
    new Person { Name = "Sam", Age = 20, City = "Dushanbe" },
    new Person { Name = "Lola", Age = 24, City = "Khujand" },
    new Person { Name = "Tim", Age = 26, City = "Bokhtar" }
};
double averageAge = people8.Average(person => person.Age);
PrintTitle("Task 8");
Console.WriteLine($"Average age: {averageAge:F2}");

// Task 9
List<int> numbers9 = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
List<int> uniqueNumbers = numbers9.Distinct().ToList();
PrintTitle("Task 9");
Console.WriteLine(string.Join(", ", uniqueNumbers));

// Task 10
List<string> lines10 = new List<string> { "level", "apple", "madam", "code" };
PrintTitle("Task 10");
foreach (string line in lines10)
{
    string reversed = new string(line.Reverse().ToArray());
    bool isPalindrome = string.Equals(line, reversed, StringComparison.OrdinalIgnoreCase);
    Console.WriteLine($"{line} -> {isPalindrome}");
}

// Task 11
List<Person> people11 = new List<Person>
{
    new Person { Name = "A", Age = 18, City = "Dushanbe" },
    new Person { Name = "B", Age = 21, City = "Khujand" },
    new Person { Name = "C", Age = 30, City = "Dushanbe" }
};
List<Person> onlyDushanbe = people11.Where(person => person.City == "Dushanbe").ToList();
PrintTitle("Task 11");
foreach (Person person in onlyDushanbe)
{
    Console.WriteLine($"{person.Name} - {person.City}");
}

// Task 12
List<string> lines12 = new List<string> { "one", "two", "three" };
string combined = string.Join(";", lines12);
PrintTitle("Task 12");
Console.WriteLine(combined);

// Task 13
List<int> numbers13 = new List<int> { 10, 20, 30, 40, 50, 60 };
int oddIndexSum = 0;
for (int i = 1; i < numbers13.Count; i += 2)
{
    oddIndexSum += numbers13[i];
}
PrintTitle("Task 13");
Console.WriteLine($"Sum of odd index elements: {oddIndexSum}");

// Task 14
List<string> lines14 = new List<string> { "sun", "international", "book", "programming" };
string longestLine = lines14.OrderByDescending(line => line.Length).First();
PrintTitle("Task 14");
Console.WriteLine($"Longest line: {longestLine}");

// Task 15
List<Person> people15 = new List<Person>
{
    new Person { Name = "Karim", Age = 25, City = "Dushanbe" },
    new Person { Name = "Ali", Age = 19, City = "Khujand" },
    new Person { Name = "Bahrom", Age = 27, City = "Bokhtar" }
};
people15.Sort((first, second) => string.Compare(first.Name, second.Name, StringComparison.Ordinal));
PrintTitle("Task 15");
foreach (Person person in people15)
{
    Console.WriteLine(person.Name);
}

// Task 16
List<int> numbers16 = new List<int> { 1, 3, 4, 6, 7, 9, 2, 8 };
int target = 10;
PrintTitle("Task 16");
for (int i = 0; i < numbers16.Count; i++)
{
    for (int j = i + 1; j < numbers16.Count; j++)
    {
        if (numbers16[i] + numbers16[j] == target)
        {
            Console.WriteLine($"{numbers16[i]} + {numbers16[j]} = {target}");
        }
    }
}

// Task 17
List<Person> people17 = new List<Person>
{
    new Person { Name = "Nisa", Age = 18, City = "Dushanbe" },
    new Person { Name = "Rustam", Age = 24, City = "Khujand" },
    new Person { Name = "Madina", Age = 30, City = "Bokhtar" }
};
double avgAge17 = people17.Average(person => person.Age);
List<Person> olderThanAverage = people17.Where(person => person.Age > avgAge17).ToList();
PrintTitle("Task 17");
Console.WriteLine($"Average age: {avgAge17:F2}");
foreach (Person person in olderThanAverage)
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}

// Task 18
List<string> lines18 = new List<string> { "first test", "second", "unit test", "final" };
string partToDelete = "test";
lines18.RemoveAll(line => line.Contains(partToDelete, StringComparison.OrdinalIgnoreCase));
PrintTitle("Task 18");
foreach (string line in lines18)
{
    Console.WriteLine(line);
}

// Task 19
List<int> numbers19 = new List<int> { -3, 5, -8, 10, -1 };
for (int i = 0; i < numbers19.Count; i++)
{
    if (numbers19[i] < 0)
    {
        numbers19[i] = Math.Abs(numbers19[i]);
    }
}
PrintTitle("Task 19");
Console.WriteLine(string.Join(", ", numbers19));

// Task 20
List<Person> people20 = new List<Person>
{
    new Person { Name = "Alisher", Age = 22, City = "Dushanbe" },
    new Person { Name = "Nodira", Age = 21, City = "Khujand" },
    new Person { Name = "Suhrob", Age = 24, City = "Dushanbe" },
    new Person { Name = "Malika", Age = 20, City = "Khujand" },
    new Person { Name = "Parviz", Age = 23, City = "Bokhtar" }
};
PrintTitle("Task 20");
var groupedPeople = people20.GroupBy(person => person.City);
foreach (var group in groupedPeople)
{
    Console.WriteLine(group.Key + ":");
    foreach (Person person in group)
    {
        Console.WriteLine($"  {person.Name} ({person.Age})");
    }
}

static void PrintTitle(string title)
{
    Console.WriteLine();
    Console.WriteLine("===== " + title + " =====");
}

public class Person
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string City { get; set; } = string.Empty;
}
