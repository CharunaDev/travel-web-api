using Microsoft.AspNetCore.Identity;
using travel_api.Data;
using travel_api.Models;

namespace travel_api.Migrations
{
    public class Seed
    {
        private readonly APIContext _context;
        public Seed(APIContext context)
        {
            _context = context;
        }
        public void SeedDataContext()
        {
            if (!_context.Roles.Any())
            {
                _context.Roles.AddRange(
                    new Role { RoleName = "Admin" },
                    new Role { RoleName = "NormalUsers" },
                    new Role { RoleName = "HotelOwner" }
                );
                _context.SaveChanges();
            }

            if (!_context.Users.Any())
            {

                var adminUsers = new Users
                {
                    Username = "admin",
                    Email = "admin@example.com",
                    FirstName = "Admin",
                    LastName = "Users",
                    IsActive = true,
                    RoleId = _context.Roles.First(r => r.RoleName == "Admin").Id,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("123456789"),
                    CreateDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                };
                var normalUsers = new Users
                {
                    Username = "user",
                    Email = "Users@example.com",
                    FirstName = "Normal",
                    LastName = "Users",
                    IsActive=true,
                    RoleId = _context.Roles.First(r => r.RoleName == "NormalUsers").Id,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("123456789"),
                    CreateDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                };

                var hotelOwner = new Users
                {
                    Username = "hotelowner",
                    Email = "owner@example.com",
                    FirstName = "Hotel",
                    LastName = "Owner",
                    IsActive=true,
                    RoleId = _context.Roles.First(r => r.RoleName == "HotelOwner").Id,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("123456789"),
                    CreateDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                };

                _context.Users.AddRange(adminUsers, normalUsers, hotelOwner);
                _context.SaveChanges();
            }
        }
    }
}
