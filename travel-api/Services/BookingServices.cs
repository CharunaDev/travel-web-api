using Microsoft.EntityFrameworkCore;
using travel_api.Data;
using travel_api.Interfaces;
using travel_api.Models;

namespace travel_api.Services
{
    public class BookingServices : IBookingServices
    {
        private IRepository<Booking> _repository;
        private readonly APIContext _context;
        private DbSet<Booking> _entities;
        public BookingServices(IRepository<Booking> repository, APIContext context)
        {
            _repository = repository;
            _context = context;
            _entities = context.Set<Booking>();
        }

        public IEnumerable<Booking> GetAllBookings()
        {
            throw new NotImplementedException();
        }

        public Booking GetBookingById(int id)
        {
            throw new NotImplementedException();
        }

        public Booking AddBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public void UpdateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public void DeleteBooking(int id)
        {
            throw new NotImplementedException();
        }
    }
}
