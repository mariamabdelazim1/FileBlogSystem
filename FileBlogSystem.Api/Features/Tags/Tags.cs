public class Tag
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Posts { get; set; } = new(); // List of slugs
}
