namespace Domain.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int VoteAmount { get; set; }
    public DateTime CreatedAt { get; set; }
}
