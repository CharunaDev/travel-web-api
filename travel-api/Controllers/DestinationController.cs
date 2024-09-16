using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using travel_api.Dto;
using travel_api.Infrastructure;
using travel_api.Interfaces;
using travel_api.Models;

namespace travel_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private readonly IDestinationServices _destinationServices;
        private readonly IMapper _mapper;
        public DestinationController(IDestinationServices destinationServices, IMapper mapper)
        {
            _destinationServices = destinationServices;
            _mapper = mapper;
        }
        [HttpGet(nameof(GetAllDestinations))]
        public IActionResult GetAllDestinations()
        {
            var _destinations = _mapper.Map<IEnumerable<DestinationsDto>>(_destinationServices.GetAllDestinations());
            if (_destinations != null)
            {
                return Ok(_destinations);
            }
            return BadRequest(new { errorMessage = CustomMessage.NO_RECORD_FOUND });
        }

        [HttpGet(nameof(GetDestinationsById))]
        public IActionResult GetDestinationsById(int id)
        {
            var _destination = _mapper.Map<DestinationsDto>(_destinationServices.GetDestinationById(id));
            if (_destination != null) {
                return Ok(_destination);
            }
            return BadRequest(new { errorMessage = CustomMessage.NO_RECORD_FOUND });
        }
    
    }
}
