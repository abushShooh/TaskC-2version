public abstract class AbstractBook : Readable
{
    private string title = "";
    private string author = "";

    public void SetTitle(string title)
    {
        this.title = title;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetAuthor(string author)
    {
        this.author = author;
    }

    public string GetAuthor()
    {
        return author;
    }

    public virtual void Read()
    {
        Console.WriteLine($"Reading: {title} by {author}");
    }
}
