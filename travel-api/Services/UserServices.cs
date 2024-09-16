using Microsoft.EntityFrameworkCore;
using travel_api.Data;
using travel_api.Interfaces;
using travel_api.Models;

namespace travel_api.Services
{
    public class UserServices : IUserServices
    {
        private IRepository<Users> _repository;
        private readonly APIContext _context;
        private DbSet<Users> _entities;

        public UserServices(IRepository<Users> repository, APIContext context)
        {
            _repository = repository;
            _context = context;
            _entities = context.Set<Users>();
        }
        public void DeleteUser(int id)
        {
            Users user = GetUser(id);
            _repository.Remove(user);
            _repository.SaveChanges();
        }
        public IEnumerable<Users> GetAllUsers(int offSet, int limit, string name)
        {
            //return _repository.GetAll();
            return _entities.Where(x => x.Username == name || name == null).Include(x => x.Role).AsEnumerable().Skip((offSet - 1) * limit).Take(limit);
        }
        public Users GetUser(int Id)
        {
            return _repository.Get(Id);
        }
        public Users InsertUser(Users user)
        {
            return _repository.Insert(user);
        }
        public Users Login(Users user)
        {
            var loginUser = _entities.Include(x => x.Role).FirstOrDefault(x => x.Username == user.Username);

            bool invalidPassword = BCrypt.Net.BCrypt.Verify(user.PasswordHash, loginUser.PasswordHash);

            if (invalidPassword)
            {
                return loginUser;
            }
            else
            {
                return null;
            }
        }
        public void UpdateUser(Users user)
        {
            _repository.Update(user);
        }
        public Users GetUserToken(string token)
        {
            var user = _entities.Include(x => x.Role).FirstOrDefault(x => x.Token == token);
            if (user != null)
            {
                return user;
            }
            return null;
        }
        public bool UserExists(string username)
        {
            bool _usernameExists = _entities.Any(x => x.Username == username);
            return _usernameExists;
        }
        public int TotalRecord(string name)
        {
            return _entities.Where(x => x.Username == name || name == null).Count();
        }

        public Users ActiveUser(Users user)
        {
            var _user = _entities.FirstOrDefault(x => x.Id == user.Id);
            _user.IsActive = user.IsActive;
            _user.RoleId = user.RoleId;
            _repository.SaveChanges();
            var updateUser = this.GetUser(user.Id);
            return updateUser;
        }
        public Users GetUserByEmail(Users user)
        {
            return _entities.Where(x => x.Email == user.Email).FirstOrDefault();
        }
        public Users GetUserByPasswordResetToken(Users user)
        {
            return _entities.Where(x => x.Id == user.Id).FirstOrDefault();
        }
    }
}
