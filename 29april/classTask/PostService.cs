public class PostService
{
    private readonly List<Post> posts = new();
    private int nextId = 1;

    public void CreatePost(string title, string description, int categoryId)
    {
        Post post = new Post
        {
            Id = nextId,
            Title = title,
            Description = description,
            CreatedAt = DateTime.Now,
            CategoryId = categoryId
        };

        posts.Add(post);
        nextId++;
    }

    public List<Post> GetPosts()
    {
        return posts;
    }

    public Post? GetPostById(int id)
    {
        return posts.FirstOrDefault(p => p.Id == id);
    }

    public Post? GetPostByName(string name)
    {
        return posts.FirstOrDefault(p =>
            p.Title.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public List<Post> GetPostsByDate(DateTime date)
    {
        return posts.Where(p => p.CreatedAt.Date == date.Date).ToList();
    }

    public List<Post> GetPostsByCategoryId(int id)
    {
        return posts.Where(p => p.CategoryId == id).ToList();
    }

    public List<Post> GetPostCategoryId(int id)
    {
        return GetPostsByCategoryId(id);
    }

    public void DeletePost(int id)
    {
        Post? foundPost = posts.FirstOrDefault(p => p.Id == id);

        if (foundPost != null)
        {
            posts.Remove(foundPost);
        }
    }
}
