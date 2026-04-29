public class CategoryService
{
    private readonly List<Category> categories = new();
    private int nextId = 1;

    public void CreateCategory(string name)
    {
        Category category = new Category
        {
            Id = nextId,
            Name = name,
            CreatedAt = DateTime.Now
        };

        categories.Add(category);
        nextId++;
    }

    public List<Category> GetCategories()
    {
        return categories;
    }

    public Category? GetCategoryById(int id)
    {
        return categories.FirstOrDefault(c => c.Id == id);
    }

    public Category? GetCategoryByName(string name)
    {
        return categories.FirstOrDefault(c =>
            c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public List<Category> GetCategoryByDate(DateTime date)
    {
        return categories.Where(c => c.CreatedAt.Date == date.Date).ToList();
    }

    public void DeleteCategory(int id)
    {
        Category? foundCategory = categories.FirstOrDefault(c => c.Id == id);

        if (foundCategory != null)
        {
            categories.Remove(foundCategory);
        }
    }
}
