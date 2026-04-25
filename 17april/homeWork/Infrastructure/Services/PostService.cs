using Domain.Models;

namespace Infrastructure.Services;

public class PostService
{
    private readonly List<Post> posts = new();

    public List<Post> GetPosts()
    {
        return posts;
    }

    public void AddPost(Post post)
    {
        posts.Add(post);
    }

    public void UpdatePost(Post post)
    {
        Post? foundPost = posts.FirstOrDefault(p => p.Id == post.Id);

        if (foundPost != null)
        {
            foundPost.Title = post.Title;
            foundPost.Description = post.Description;
            foundPost.VoteAmount = post.VoteAmount;
            foundPost.CreatedAt = post.CreatedAt;
        }
    }

    public void Delete(int id)
    {
        Post? foundPost = posts.FirstOrDefault(p => p.Id == id);

        if (foundPost != null)
        {
            posts.Remove(foundPost);
        }
    }
}
