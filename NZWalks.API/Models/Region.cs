namespace NZWalks.API.Models
{
    public class Region
    {
        public Guid Id { get; set; }

        public String Code { get; set; }

        public String Name { get; set; }

        public string? RegionImageUrl { get; set; }
    }
}
