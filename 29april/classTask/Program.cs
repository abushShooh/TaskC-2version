CategoryService categoryService = new CategoryService();
PostService postService = new PostService();

bool work = true;

while (work)
{
    ShowMenu();
    Console.Write("Choose action: ");
    string command = Console.ReadLine() ?? "";

    switch (command)
    {
        case "1":
            CreateCategory(categoryService);
            break;
        case "2":
            ShowCategories(categoryService);
            break;
        case "3":
            ShowCategoryById(categoryService);
            break;
        case "4":
            ShowCategoryByName(categoryService);
            break;
        case "5":
            ShowCategoriesByDate(categoryService);
            break;
        case "6":
            DeleteCategory(categoryService);
            break;
        case "7":
            CreatePost(postService, categoryService);
            break;
        case "8":
            ShowPosts(postService, categoryService);
            break;
        case "9":
            ShowPostById(postService, categoryService);
            break;
        case "10":
            ShowPostByName(postService, categoryService);
            break;
        case "11":
            ShowPostsByDate(postService, categoryService);
            break;
        case "12":
            ShowPostsByCategoryId(postService, categoryService);
            break;
        case "13":
            DeletePost(postService);
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
    Console.WriteLine("===== POST MENU =====");
    Console.WriteLine("1  - Create category");
    Console.WriteLine("2  - Show all categories");
    Console.WriteLine("3  - Show category by id");
    Console.WriteLine("4  - Show category by name");
    Console.WriteLine("5  - Show categories by date");
    Console.WriteLine("6  - Delete category");
    Console.WriteLine("7  - Create post");
    Console.WriteLine("8  - Show all posts");
    Console.WriteLine("9  - Show post by id");
    Console.WriteLine("10 - Show post by name");
    Console.WriteLine("11 - Show posts by date");
    Console.WriteLine("12 - Show posts by category id");
    Console.WriteLine("13 - Delete post");
    Console.WriteLine("0  - Exit");
}

static void CreateCategory(CategoryService categoryService)
{
    Console.Write("Category name: ");
    string name = Console.ReadLine() ?? "";

    if (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Category name cannot be empty.");
        return;
    }

    categoryService.CreateCategory(name);
    Console.WriteLine("Category created.");
}

static void ShowCategories(CategoryService categoryService)
{
    List<Category> categories = categoryService.GetCategories();

    if (categories.Count == 0)
    {
        Console.WriteLine("No categories.");
        return;
    }

    foreach (Category category in categories)
    {
        PrintCategory(category);
    }
}

static void ShowCategoryById(CategoryService categoryService)
{
    int id = ReadInt("Enter category id: ");
    Category? category = categoryService.GetCategoryById(id);

    if (category == null)
    {
        Console.WriteLine("Category not found.");
        return;
    }

    PrintCategory(category);
}

static void ShowCategoryByName(CategoryService categoryService)
{
    Console.Write("Enter category name: ");
    string name = Console.ReadLine() ?? "";

    Category? category = categoryService.GetCategoryByName(name);

    if (category == null)
    {
        Console.WriteLine("Category not found.");
        return;
    }

    PrintCategory(category);
}

static void ShowCategoriesByDate(CategoryService categoryService)
{
    DateTime date = ReadDate("Enter date (yyyy-MM-dd): ");
    List<Category> categories = categoryService.GetCategoryByDate(date);

    if (categories.Count == 0)
    {
        Console.WriteLine("No categories for selected date.");
        return;
    }

    foreach (Category category in categories)
    {
        PrintCategory(category);
    }
}

static void DeleteCategory(CategoryService categoryService)
{
    int id = ReadInt("Enter category id for delete: ");
    categoryService.DeleteCategory(id);
    Console.WriteLine("Delete action finished.");
}

static void CreatePost(PostService postService, CategoryService categoryService)
{
    Console.Write("Post title: ");
    string title = Console.ReadLine() ?? "";

    Console.Write("Post description: ");
    string description = Console.ReadLine() ?? "";

    int categoryId = ReadInt("Category id: ");

    Category? category = categoryService.GetCategoryById(categoryId);
    if (category == null)
    {
        Console.WriteLine("Category not found.");
        return;
    }

    if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
    {
        Console.WriteLine("Title and description cannot be empty.");
        return;
    }

    postService.CreatePost(title, description, categoryId);
    Console.WriteLine("Post created.");
}

static void ShowPosts(PostService postService, CategoryService categoryService)
{
    List<Post> posts = postService.GetPosts();

    if (posts.Count == 0)
    {
        Console.WriteLine("No posts.");
        return;
    }

    foreach (Post post in posts)
    {
        PrintPost(post, categoryService);
    }
}

static void ShowPostById(PostService postService, CategoryService categoryService)
{
    int id = ReadInt("Enter post id: ");
    Post? post = postService.GetPostById(id);

    if (post == null)
    {
        Console.WriteLine("Post not found.");
        return;
    }

    PrintPost(post, categoryService);
}

static void ShowPostByName(PostService postService, CategoryService categoryService)
{
    Console.Write("Enter post name: ");
    string name = Console.ReadLine() ?? "";

    Post? post = postService.GetPostByName(name);

    if (post == null)
    {
        Console.WriteLine("Post not found.");
        return;
    }

    PrintPost(post, categoryService);
}

static void ShowPostsByDate(PostService postService, CategoryService categoryService)
{
    DateTime date = ReadDate("Enter date (yyyy-MM-dd): ");
    List<Post> posts = postService.GetPostsByDate(date);

    if (posts.Count == 0)
    {
        Console.WriteLine("No posts for selected date.");
        return;
    }

    foreach (Post post in posts)
    {
        PrintPost(post, categoryService);
    }
}

static void ShowPostsByCategoryId(PostService postService, CategoryService categoryService)
{
    int categoryId = ReadInt("Enter category id: ");
    List<Post> posts = postService.GetPostsByCategoryId(categoryId);

    if (posts.Count == 0)
    {
        Console.WriteLine("No posts for selected category.");
        return;
    }

    foreach (Post post in posts)
    {
        PrintPost(post, categoryService);
    }
}

static void DeletePost(PostService postService)
{
    int id = ReadInt("Enter post id for delete: ");
    postService.DeletePost(id);
    Console.WriteLine("Delete action finished.");
}

static void PrintCategory(Category category)
{
    Console.WriteLine($"Id: {category.Id}, Name: {category.Name}, CreatedAt: {category.CreatedAt}");
}

static void PrintPost(Post post, CategoryService categoryService)
{
    Category? category = categoryService.GetCategoryById(post.CategoryId);
    string categoryName = category != null ? category.Name : "Unknown";

    Console.WriteLine(
        $"Id: {post.Id}, Title: {post.Title}, Description: {post.Description}, CreatedAt: {post.CreatedAt}, Category: {categoryName}");
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

static DateTime ReadDate(string text)
{
    while (true)
    {
        Console.Write(text);
        string input = Console.ReadLine() ?? "";

        if (DateTime.TryParse(input, out DateTime date))
        {
            return date;
        }

        Console.WriteLine("Wrong date format.");
    }
}
