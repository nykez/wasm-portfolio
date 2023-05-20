namespace Portfolio.Models
{
    public class SocalLinks
    {
        public string? Style { get; set; }
        public string? Url { get; set; }
    }

    public class AboutMe
    {
        public string? Name { get; set; }
        public string? About { get; set; }
        public string? AvtarUrl { get; set; }
        public string[]? Titles { get; set; }
        public List<SocalLinks> SocialLinks { get; set; } = new List<SocalLinks>();
    }
}
