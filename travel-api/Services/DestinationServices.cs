using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using travel_api.Data;
using travel_api.Interfaces;
using travel_api.Models;

namespace travel_api.Services
{
    public class DestinationServices : IDestinationServices
    {
        private IRepository<Destinations> _repository;
        private readonly APIContext _context;
        private DbSet<Destinations> _entities;

        public DestinationServices(IRepository<Destinations> repository, APIContext context)
        {
            _repository = repository;
                _context = context;
            _entities = context.Set<Destinations>();
        }

        public IEnumerable<Destinations> GetAllDestinations()
        {
            return _entities.AsEnumerable();
        }

        public Destinations GetDestinationById(int id)
        {
            return _repository.Get(id);
        }

        public Destinations AddDestination(Destinations destination)
        {
            return _repository.Insert(destination);
        }

        public void UpdateDestination(Destinations destination)
        {
            _repository.Update(destination);
        }

        public void DeleteDestination(int id)
        {
            Destinations destinations = GetDestinationById(id);
            _repository.Remove(destinations);
            _repository.SaveChanges();
        }
    }
}
