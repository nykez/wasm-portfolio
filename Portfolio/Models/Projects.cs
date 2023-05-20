namespace Portfolio.Models
{
    public class Tags
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class Project
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public List<Tags> Tags { get; set; } = new List<Tags>();
    }
}
