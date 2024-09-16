using AutoMapper;
using travel_api.Dto;
using travel_api.Models;

namespace travel_api.Mapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Destinations, DestinationsDto>();
        }
    }
}
