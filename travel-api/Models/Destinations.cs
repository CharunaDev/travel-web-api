namespace travel_api.Models
{
    public class Destinations : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Province { get; set; }
        public string? City { get; set; }
        public bool IsActive { get; set; }

        // Navigation property
        public ICollection<Hotel>? Hotels { get; set; }
    }
}
