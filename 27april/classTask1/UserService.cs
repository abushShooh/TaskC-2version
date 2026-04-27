public class UserList : IUSER
{
    private List<User> users = new List<User>();
    private int nextId = 1;

    public User AddUser(string name, string surName, string email, int age)
    {
        User user = new User(nextId, name, surName, email, age);
        users.Add(user);
        nextId++;
        return user;
    }

    public bool RemoveUser(int id)
    {
        User? user = users.FirstOrDefault(u => u.ID == id);
        if (user is null)
        {
            return false;
        }

        users.Remove(user);
        return true;
    }

    public bool UpdateUser(int id, string name, string surName, string email, int age)
    {
        User? user = users.FirstOrDefault(u => u.ID == id);
        if (user is null)
        {
            return false;
        }

        user.UpdateData(name, surName, email, age);
        return true;
    }

    public List<User> GetUsers()
    {
        return users;
    }

    public User? GetUserById(int id)
    {
        return users.FirstOrDefault(u => u.ID == id);
    }
}
