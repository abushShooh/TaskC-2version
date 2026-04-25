List<string> fruits = new List<string>();

// 1-2
fruits.Add("apple");
fruits.Add("banana");
fruits.Add("orange");

// 3
Console.WriteLine($"Count: {fruits.Count}");

// 4
PrintList("All elements", fruits);

// 5
fruits.Remove("banana");
PrintList("After removing banana", fruits);

// 6
Console.WriteLine($"Contains apple: {fruits.Contains("apple")}");

// Save current data before clear so we can use it in the next steps.
List<string> originalFruits = new List<string>(fruits);

// 7
fruits.Clear();
Console.WriteLine($"List is empty after clear: {fruits.Count == 0}");

// 8
List<string> copiedFruits = new List<string>(originalFruits);
PrintList("Copied list", copiedFruits);

// 9
copiedFruits.Insert(0, "grape");
PrintList("After inserting grape", copiedFruits);

// 10 (position 2 means index 1)
if (copiedFruits.Count > 1)
{
    string removedValue = copiedFruits[1];
    copiedFruits.RemoveAt(1);
    Console.WriteLine($"Removed value at position 2: {removedValue}");
}

// 11
Console.WriteLine($"Copied list is empty: {copiedFruits.Count == 0}");

// 12
copiedFruits.Sort();
PrintList("Sorted A-Z", copiedFruits);

// 13
copiedFruits.Reverse();
PrintList("Reversed order", copiedFruits);

// 14
List<string> extraFruits = new List<string> { "strawberry", "blueberry", "raspberry" };
List<string> mergedFruits = new List<string>(copiedFruits);
mergedFruits.AddRange(extraFruits);
PrintList("Merged list", mergedFruits);

// 15
Console.WriteLine($"Index of apple: {mergedFruits.IndexOf("apple")}");

// 16
mergedFruits.RemoveAll(fruit => fruit.Length > 5);
PrintList("After removing strings with length > 5", mergedFruits);

// 17
int startsWithACount = mergedFruits.Count(fruit => fruit.StartsWith("a"));
Console.WriteLine($"Count of items starting with 'a': {startsWithACount}");

// 18
mergedFruits.Sort();
mergedFruits.Reverse();
PrintList("Sorted in reverse order", mergedFruits);

// 19
Console.WriteLine($"One line: {string.Join(", ", mergedFruits)}");

static void PrintList(string title, List<string> items)
{
    Console.WriteLine();
    Console.WriteLine(title + ":");

    foreach (string item in items)
    {
        Console.WriteLine(item);
    }
}
