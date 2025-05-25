public class PostMeta
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty; // custom URL
    public List<string> Tags { get; set; } = [];
    public List<string> Categories { get; set; } = [];
    public DateTime PublishedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public bool IsDraft { get; set; } = true;
}
