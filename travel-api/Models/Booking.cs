namespace travel_api.Models
{
    public class Booking : BaseEntity
    {
        public int? UserId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public bool IsActive { get; set; }

        // Navigation properties
        public Users? User { get; set; }
        public Room? Room { get; set; }
    }
}
