public class Person
{
    public string Name { get; set; } = "";
    public string SurName { get; set; } = "";
    public int Age { get; set; }

    public Person()
    {
    }

    public Person(string name, string surName, int age)
    {
        Name = name;
        SurName = surName;
        Age = age;
    }

    public virtual string GetInfo()
    {
        return $"Имя: {Name}, Фамилия: {SurName}, Возраст: {Age}";
    }
}

public class User : Person
{
    public int ID { get; set; }
    public string Email { get; set; } = "";

    public User()
    {
    }

    public User(int id, string name, string surName, string email, int age)
        : base(name, surName, age)
    {
        ID = id;
        Email = email;
    }

    public void UpdateData(string name, string surName, string email, int age)
    {
        Name = name;
        SurName = surName;
        Email = email;
        Age = age;
    }

    public override string GetInfo()
    {
        return $"ID: {ID}, Имя: {Name}, Фамилия: {SurName}, Email: {Email}, Возраст: {Age}";
    }
}
