// Task 1
List<int> numbersTask1 = new List<int> { 1, 2, 3, 4, 5 };
int sum = numbersTask1.Sum();
Console.WriteLine("Task 1");
Console.WriteLine("The sum of all the elements in the list is: " + sum);
Console.WriteLine();

// Task 2
List<string> words = new List<string> { "hello", "world", "!" };
string concat = string.Concat(words);
Console.WriteLine("Task 2");
Console.WriteLine("The concatenated string is: " + concat);
Console.WriteLine();

// Task 3
List<DateTime> dates = new List<DateTime>
{
    new DateTime(2020, 10, 1),
    new DateTime(2022, 8, 15),
    new DateTime(2021, 4, 28)
};
dates.Sort();
Console.WriteLine("Task 3");
Console.WriteLine("The sorted dates are:");
foreach (DateTime date in dates)
{
    Console.WriteLine(date.ToShortDateString());
}
Console.WriteLine();

// Task 4
List<double> numbersTask4 = new List<double> { 3.5, 2.7, 6.9, 1.2 };
double average = numbersTask4.Average();
Console.WriteLine("Task 4");
Console.WriteLine("The average value of all the elements in the list is: " + average);
Console.WriteLine();

// Task 5
List<int> numbersTask5 = new List<int> { 1, 2, 3, 4, 5 };
List<int> evenNumbers = numbersTask5.FindAll(number => number % 2 == 0);
Console.WriteLine("Task 5");
Console.WriteLine("The filtered numbers are:");
foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine();

// Task 6
List<bool> values = new List<bool> { true, true, true };
bool allTrue = values.All(value => value);
Console.WriteLine("Task 6");
Console.WriteLine("Are all the values in the list true? " + allTrue);
Console.WriteLine();

// Task 7
List<string> itemsTask7 = new List<string> { "apple", "banana", "cherry" };
itemsTask7.Remove("banana");
Console.WriteLine("Task 7");
Console.WriteLine("List after removal:");
foreach (string item in itemsTask7)
{
    Console.WriteLine(item);
}
Console.WriteLine();

// Task 8
List<string> itemsTask8 = new List<string> { "apple", "banana", "cherry" };
bool found = itemsTask8.Contains("banana");
Console.WriteLine("Task 8");
Console.WriteLine("Is the element found? " + found);
Console.WriteLine();

// Task 9
List<int> numbersTask9 = new List<int>();
numbersTask9.Add(10);
numbersTask9.Add(20);
numbersTask9.Add(30);
Console.WriteLine("Task 9");
Console.WriteLine("All numbers in the list:");
foreach (int number in numbersTask9)
{
    Console.WriteLine(number);
}
Console.WriteLine();

// Task 10
List<int> numbersTask10 = new List<int>();
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    numbersTask10.Add(random.Next(1, 101));
}
Console.WriteLine("Task 10");
Console.WriteLine("Random numbers in the list:");
foreach (int number in numbersTask10)
{
    Console.WriteLine(number);
}
