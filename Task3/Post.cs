public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; set; }
    public List<string> Comments = new List<string>();
    public bool IsPublished { get; set; }
    public string Publish()
    {
        return "The post is published.";
        IsPublished = true;
    }
    public void Like()
    {
        LikeCount ++;
    }
    public void Comment(string message)
    {
        Comments.Add(message);
    }
    
}