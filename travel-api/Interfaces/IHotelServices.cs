using travel_api.Models;

namespace travel_api.Interfaces
{
    public interface IHotelServices
    {
        IEnumerable<Hotel> GetAllHotels();
        Hotel GetHotelById(int id);
        Hotel AddHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);
    }
}
