var post = new Post();
post.Title = Console.ReadLine();
post.Description = Console.ReadLine();
post.LikeCount = Convert.ToInt32(Console.ReadLine());
post.Comments = Console.ReadLine();
post.IsPublished = Convert.ToBoolean(Console.ReadLine());

class Post
{
    public string Title;
    public string Description;
    public int LikeCount;
    public string Comments;
    public bool IsPublished;

    public string Publish()
    {
        IsPublished = true;
        return $"The post is published.";
    }
    public void Like()
    {
        LikeCount++;
    }
    public void Comment(string message)
    {
        
    }
}