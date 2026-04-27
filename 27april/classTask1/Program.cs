IUSER userService = new UserList();
bool work = true;

while (work)
{
    ShowMenu();
    Console.Write("Choose action: ");
    string command = Console.ReadLine() ?? "";

    switch (command)
    {
        case "1":
            AddUser(userService);
            break;
        case "2":
            DeleteUser(userService);
            break;
        case "3":
            UpdateUser(userService);
            break;
        case "4":
            ShowUsers(userService);
            break;
        case "5":
            ShowUserById(userService);
            break;
        case "0":
            work = false;
            Console.WriteLine("Program finished.");
            break;
        default:
            Console.WriteLine("Wrong command.");
            break;
    }

    Console.WriteLine();
}

static void ShowMenu()
{
    Console.WriteLine("===== USER MENU =====");
    Console.WriteLine("1 - Add user");
    Console.WriteLine("2 - Delete user");
    Console.WriteLine("3 - Update user");
    Console.WriteLine("4 - Show all users");
    Console.WriteLine("5 - Show user by id");
    Console.WriteLine("0 - Exit");
}

static void AddUser(IUSER userService)
{
    Console.Write("Enter name: ");
    string name = Console.ReadLine() ?? "";

    Console.Write("Enter surname: ");
    string surName = Console.ReadLine() ?? "";

    Console.Write("Enter email: ");
    string email = Console.ReadLine() ?? "";

    int age = ReadInt("Enter age: ");

    User user = userService.AddUser(name, surName, email, age);
    Console.WriteLine($"User added. Id = {user.ID}");
}

static void DeleteUser(IUSER userService)
{
    int id = ReadInt("Enter id for delete: ");
    bool deleted = userService.RemoveUser(id);

    if (deleted)
    {
        Console.WriteLine("User deleted.");
    }
    else
    {
        Console.WriteLine("User not found.");
    }
}

static void UpdateUser(IUSER userService)
{
    int id = ReadInt("Enter id for update: ");
    User? oldUser = userService.GetUserById(id);

    if (oldUser == null)
    {
        Console.WriteLine("User not found.");
        return;
    }

    Console.Write("Enter new name: ");
    string name = Console.ReadLine() ?? "";

    Console.Write("Enter new surname: ");
    string surName = Console.ReadLine() ?? "";

    Console.Write("Enter new email: ");
    string email = Console.ReadLine() ?? "";

    int age = ReadInt("Enter new age: ");

    bool updated = userService.UpdateUser(id, name, surName, email, age);

    if (updated)
    {
        Console.WriteLine("User updated.");
    }
}

static void ShowUsers(IUSER userService)
{
    List<User> users = userService.GetUsers();

    if (users.Count == 0)
    {
        Console.WriteLine("User list is empty.");
        return;
    }

    foreach (User user in users)
    {
        Person person = user;
        Console.WriteLine(person.GetInfo());
    }
}

static void ShowUserById(IUSER userService)
{
    int id = ReadInt("Enter id: ");
    User? user = userService.GetUserById(id);

    if (user == null)
    {
        Console.WriteLine("User not found.");
        return;
    }

    Person person = user;
    Console.WriteLine(person.GetInfo());
}

static int ReadInt(string text)
{
    while (true)
    {
        Console.Write(text);
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int value))
        {
            return value;
        }

        Console.WriteLine("Enter only number.");
    }
}
