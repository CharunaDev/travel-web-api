using System.Data;
using System.Runtime.Serialization;

namespace travel_api.Models
{
    public class Users : BaseEntity
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; } // For storing hashed passwords
        public string? Email { get; set; }

        // Foreign Key
        public int? RoleId { get; set; }
        public Role Role { get; set; }

        // Additional user details
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Token { get; set; }
        public bool IsActive { get; set; }
  
    }
}
