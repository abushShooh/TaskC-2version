Console.WriteLine("Polymorphism");
List<PolymorphismDemo.User> users = new List<PolymorphismDemo.User>
{
    new PolymorphismDemo.RegularUser("ali_user"),
    new PolymorphismDemo.Influencer("instagram_star", 120000)
};

foreach (PolymorphismDemo.User user in users)
{
    user.ViewActivity();
}

Console.WriteLine();
Console.WriteLine("Virtual Methods");
VirtualMethodsDemo.Photo photo = new VirtualMethodsDemo.Photo("beach.png");
VirtualMethodsDemo.Photo processedPhoto = new VirtualMethodsDemo.ProcessedPhoto("beach.png", "Warm Filter");

photo.Display();
processedPhoto.Display();

Console.WriteLine();
Console.WriteLine("Abstract Classes");
List<AccountDemo.Account> accounts = new List<AccountDemo.Account>
{
    new AccountDemo.UserAccount("simple_user", 320, true),
    new AccountDemo.BusinessAccount("coffee_shop", 18400, "Food & Drinks")
};

foreach (AccountDemo.Account account in accounts)
{
    account.LogIn();
    account.ShowInfo();
}

Console.WriteLine();
Console.WriteLine("Abstract Methods");
List<PublicationDemo.Publication> publications = new List<PublicationDemo.Publication>
{
    new PublicationDemo.Photo("Sunset", "1080x1080"),
    new PublicationDemo.Video("Travel Vlog", 95)
};

foreach (PublicationDemo.Publication publication in publications)
{
    publication.Publish();
}

namespace PolymorphismDemo
{
    public class User
    {
        public string UserName { get; set; }

        public User(string userName)
        {
            UserName = userName;
        }

        public virtual void ViewActivity()
        {
            Console.WriteLine($"{UserName} viewed activity.");
        }
    }

    public class RegularUser : User
    {
        public RegularUser(string userName) : base(userName)
        {
        }

        public override void ViewActivity()
        {
            Console.WriteLine($"{UserName} can view only personal activity.");
        }
    }

    public class Influencer : User
    {
        public int FollowersCount { get; set; }

        public Influencer(string userName, int followersCount) : base(userName)
        {
            FollowersCount = followersCount;
        }

        public override void ViewActivity()
        {
            Console.WriteLine($"{UserName} can view followers activity. Followers: {FollowersCount}");
        }
    }
}

namespace VirtualMethodsDemo
{
    public class Photo
    {
        public string FileName { get; set; }

        public Photo(string fileName)
        {
            FileName = fileName;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Displaying photo: {FileName}");
        }
    }

    public class ProcessedPhoto : Photo
    {
        public string FilterName { get; set; }

        public ProcessedPhoto(string fileName, string filterName) : base(fileName)
        {
            FilterName = filterName;
        }

        public override void Display()
        {
            Console.WriteLine($"Displaying processed photo: {FileName}");
            Console.WriteLine($"Applied filter/effect: {FilterName}");
        }
    }
}

namespace AccountDemo
{
    public abstract class Account
    {
        public string UserName { get; set; }
        public int FollowersCount { get; set; }

        protected Account(string userName, int followersCount)
        {
            UserName = userName;
            FollowersCount = followersCount;
        }

        public void LogIn()
        {
            Console.WriteLine($"{UserName} logged in.");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"UserName: {UserName}");
            Console.WriteLine($"Followers: {FollowersCount}");
        }
    }

    public class UserAccount : Account
    {
        public bool IsPrivate { get; set; }

        public UserAccount(string userName, int followersCount, bool isPrivate)
            : base(userName, followersCount)
        {
            IsPrivate = isPrivate;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Account type: UserAccount");
            Console.WriteLine($"Private profile: {IsPrivate}");
        }
    }

    public class BusinessAccount : Account
    {
        public string Category { get; set; }

        public BusinessAccount(string userName, int followersCount, string category)
            : base(userName, followersCount)
        {
            Category = category;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Account type: BusinessAccount");
            Console.WriteLine($"Business category: {Category}");
        }
    }
}

namespace PublicationDemo
{
    public abstract class Publication
    {
        public string Title { get; set; }

        protected Publication(string title)
        {
            Title = title;
        }

        public abstract void Publish();
    }

    public class Photo : Publication
    {
        public string Resolution { get; set; }

        public Photo(string title, string resolution) : base(title)
        {
            Resolution = resolution;
        }

        public override void Publish()
        {
            Console.WriteLine($"Photo publication: {Title}, Resolution: {Resolution}");
        }
    }

    public class Video : Publication
    {
        public int DurationSeconds { get; set; }

        public Video(string title, int durationSeconds) : base(title)
        {
            DurationSeconds = durationSeconds;
        }

        public override void Publish()
        {
            Console.WriteLine($"Video publication: {Title}, Duration: {DurationSeconds} sec");
        }
    }
}
