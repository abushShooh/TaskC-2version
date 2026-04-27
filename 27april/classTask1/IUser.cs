public interface IUSER
{
    User AddUser(string name, string surName, string email, int age);
    bool RemoveUser(int id);
    bool UpdateUser(int id, string name, string surName, string email, int age);
    List<User> GetUsers();
    User? GetUserById(int id);
}
