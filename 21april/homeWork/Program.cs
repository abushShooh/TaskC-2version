// Task 1: Last index of element
List<int> numbers1 = new List<int> { 10, 20, 30, 20, 40, 20 };
int lastIndex = numbers1.LastIndexOf(20);
PrintTitle("Task 1");
Console.WriteLine("Last index of 20: " + lastIndex);

// Task 2: Check list contains all elements of another list
List<string> mainList2 = new List<string> { "apple", "banana", "orange", "kiwi" };
List<string> checkList2 = new List<string> { "banana", "orange" };
bool containsAll = checkList2.All(item => mainList2.Contains(item));
PrintTitle("Task 2");
Console.WriteLine("Main list contains all elements: " + containsAll);

// Task 3: Reverse list
List<int> numbers3 = new List<int> { 1, 2, 3, 4, 5 };
numbers3.Reverse();
PrintTitle("Task 3");
PrintList(numbers3);

// Task 4: Check if list is empty
List<string> words4 = new List<string>();
PrintTitle("Task 4");
Console.WriteLine("List is empty: " + (words4.Count == 0));

// Task 5: Get sublist from main list
List<int> numbers5 = new List<int> { 5, 10, 15, 20, 25, 30 };
List<int> subList = numbers5.GetRange(1, 3);
PrintTitle("Task 5");
Console.WriteLine("Main list:");
PrintList(numbers5);
Console.WriteLine("Sublist:");
PrintList(subList);

// Task 6: Sort list
List<int> numbers6 = new List<int> { 9, 3, 7, 1, 5 };
numbers6.Sort();
PrintTitle("Task 6");
Console.WriteLine("Sorted ascending:");
PrintList(numbers6);
numbers6.Reverse();
Console.WriteLine("Sorted descending:");
PrintList(numbers6);

// Task 7: Clear all given lists
List<int> listA7 = new List<int> { 1, 2, 3 };
List<string> listB7 = new List<string> { "a", "b", "c" };
listA7.Clear();
listB7.Clear();
PrintTitle("Task 7");
Console.WriteLine("List A count after clear: " + listA7.Count);
Console.WriteLine("List B count after clear: " + listB7.Count);

// Task 8: Find largest and smallest elements
List<int> numbers8 = new List<int> { 12, 44, 3, 98, 27, 5 };
int maxValue = numbers8.Max();
int minValue = numbers8.Min();
PrintTitle("Task 8");
Console.WriteLine("Max: " + maxValue);
Console.WriteLine("Min: " + minValue);

// Task 9: Remove all elements matching condition
List<int> numbers9 = new List<int> { 2, 3, 4, 5, 6, 7, 8 };
numbers9.RemoveAll(number => number % 2 == 0);
PrintTitle("Task 9");
Console.WriteLine("After removing even numbers:");
PrintList(numbers9);

// Task 10: Mix list items randomly
List<string> words10 = new List<string> { "red", "blue", "green", "yellow", "white" };
Random random = new Random();
for (int i = words10.Count - 1; i > 0; i--)
{
    int randomIndex = random.Next(i + 1);
    string temp = words10[i];
    words10[i] = words10[randomIndex];
    words10[randomIndex] = temp;
}
PrintTitle("Task 10");
PrintList(words10);

static void PrintTitle(string title)
{
    Console.WriteLine();
    Console.WriteLine("===== " + title + " =====");
}

static void PrintList<T>(List<T> items)
{
    foreach (T item in items)
    {
        Console.WriteLine(item);
    }
}
