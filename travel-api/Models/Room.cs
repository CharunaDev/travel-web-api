namespace travel_api.Models
{
    public class Room : BaseEntity
    {
        public string? RoomType { get; set; } // e.g., "Single", "Double", "Suite"
        public decimal? Price { get; set; }
        public bool IsAvailable { get; set; }

        // Foreign Key
        public int? HotelId { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
