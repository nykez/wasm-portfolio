namespace Portfolio.Models.Api
{

    public class ImageArray
    {
        public string BigSpot { get; set; }
        public string Listing { get; set; }
        public string ListingSmall { get; set; }
    }

    public class Addon
    {
        public string? Id { get; set; }
        public string? TeamId { get; set; }
        public bool Active { get; set; }
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        public string? Slug { get; set; }
        public string? Route { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Views { get; set; }
        public ImageArray? Images { get; set; }
    }
}
