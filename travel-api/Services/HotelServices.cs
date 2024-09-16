using Microsoft.EntityFrameworkCore;
using travel_api.Data;
using travel_api.Interfaces;
using travel_api.Models;

namespace travel_api.Services
{
    public class HotelServices : IHotelServices
    {
        private IRepository<Hotel> _repository;
        private readonly APIContext _context;
        private DbSet<Hotel> _entities;

        public HotelServices(IRepository<Hotel> repository, APIContext context)
        {
            _repository = repository;
            _context = context;
            _entities = context.Set<Hotel>();
        }

        public IEnumerable<Hotel> GetAllHotels()
        {
            throw new NotImplementedException();
        }

        public Hotel GetHotelById(int id)
        {
            throw new NotImplementedException();
        }

        public Hotel AddHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public void UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public void DeleteHotel(int id)
        {
            throw new NotImplementedException();
        }
    }
}
