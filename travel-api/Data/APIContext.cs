using Microsoft.EntityFrameworkCore;
using travel_api.Models;
namespace travel_api.Data
{
    public class APIContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Destinations> Destinations { get; set; }
        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
            
        }
    }
}
