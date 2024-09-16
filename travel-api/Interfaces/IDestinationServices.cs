using travel_api.Models;

namespace travel_api.Interfaces
{
    public interface IDestinationServices
    {
        IEnumerable<Destinations> GetAllDestinations();
        Destinations GetDestinationById(int id);
        Destinations AddDestination(Destinations destination);
        void UpdateDestination(Destinations destination);
        void DeleteDestination(int id);
    }
}
