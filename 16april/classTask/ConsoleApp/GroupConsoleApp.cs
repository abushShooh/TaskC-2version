using Domain;
using Infrastructure;

namespace ConsoleApp;

public static class GroupConsoleApp
{
    public static void Run()
    {
        IGroupRepository repository = new GroupRepository();

        Console.WriteLine("Choose option:");

        while (true)
        {
            Console.WriteLine("1 - Create Group");
            Console.WriteLine("2 - Get Group");
            Console.WriteLine("3 - Update Group");
            Console.WriteLine("4 - Delete Group");
            Console.WriteLine("0 - Exit");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                {
                    int id = ReadInt("Enter group ID:");
                    string name = ReadRequired("Enter group name:");
                    string description = ReadRequired("Enter group description:");

                    bool created = repository.CreateGroup(new Group(id, name, description));

                    if (created)
                    {
                        Console.WriteLine("Group created successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Group with this ID already exists.");
                    }

                    break;
                }
                case "2":
                {
                    int id = ReadInt("Enter group ID:");
                    Group? group = repository.GetGroup(id);

                    if (group == null)
                    {
                        Console.WriteLine("Group not found.");
                    }
                    else
                    {
                        Console.WriteLine($"ID: {group.Id}");
                        Console.WriteLine($"Name: {group.Name}");
                        Console.WriteLine($"Description: {group.Description}");
                    }

                    break;
                }
                case "3":
                {
                    int id = ReadInt("Enter group ID to update:");
                    string name = ReadRequired("Enter new name:");
                    string description = ReadRequired("Enter new description:");

                    bool updated = repository.UpdateGroup(id, name, description);

                    if (updated)
                    {
                        Console.WriteLine("Group updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Group not found.");
                    }

                    break;
                }
                case "4":
                {
                    int id = ReadInt("Enter group ID to delete:");
                    bool deleted = repository.DeleteGroup(id);

                    if (deleted)
                    {
                        Console.WriteLine("Group deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Group not found.");
                    }

                    break;
                }
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int value))
            {
                return value;
            }

            Console.WriteLine("Please enter a valid integer.");
        }
    }

    private static string ReadRequired(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input.Trim();
            }

            Console.WriteLine("Value cannot be empty.");
        }
    }
}
