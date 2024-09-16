namespace travel_api.Models
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; } // e.g., "Admin", "NormalUser", "HotelOwner"

        public bool IsActive { get; set; }

        // Navigation property
        public ICollection<Users> Users { get; set; }
    }
}
