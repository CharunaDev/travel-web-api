using travel_api.Models;

namespace travel_api.Interfaces
{
    public interface IUserServices
    {
        IEnumerable<Users> GetAllUsers(int offset, int limit, string name);
        Users GetUser(int Id);
        Users InsertUser(Users user);
        void UpdateUser(Users user);
        void DeleteUser(int Id);
        Users Login(Users user);
        Users GetUserToken(string token);
        bool UserExists(string username);
        public int TotalRecord(string name);
        Users ActiveUser(Users user);
        public Users GetUserByEmail(Users user);
        public Users GetUserByPasswordResetToken(Users user);
    }
}
