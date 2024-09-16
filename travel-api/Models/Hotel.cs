namespace travel_api.Models
{
    public class Hotel : BaseEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public decimal? Rating { get; set; }
        public bool IsActive { get; set; }

        // Foreign Key
        public int? OwnerId { get; set; }
        public Users? Owner { get; set; }

        // Navigation property
        public ICollection<Room>? Rooms { get; set; }
    }
}
