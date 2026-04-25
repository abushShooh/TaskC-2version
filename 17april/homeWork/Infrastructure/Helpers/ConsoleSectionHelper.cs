namespace Infrastructure.Helpers;

public static class ConsoleSectionHelper
{
    public static void PrintTitle(string title)
    {
        Console.WriteLine();
        Console.WriteLine($"===== {title} =====");
    }
}
