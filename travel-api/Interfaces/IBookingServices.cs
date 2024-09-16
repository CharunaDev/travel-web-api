using travel_api.Models;

namespace travel_api.Interfaces
{
    public interface IBookingServices
    {
        IEnumerable<Booking> GetAllBookings();
        Booking GetBookingById(int id);
        Booking AddBooking(Booking booking);
        void UpdateBooking(Booking booking);
        void DeleteBooking(int id);
    }
}
