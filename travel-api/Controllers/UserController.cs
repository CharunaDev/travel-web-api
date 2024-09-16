using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using travel_api.Data;
using travel_api.Infrastructure;
using travel_api.Interfaces;

namespace travel_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userService;
        public UserController(IUserServices user)
        {
            _userService = user;
        }
        [HttpGet(nameof(GetAllUsers))]
        public IActionResult GetAllUsers(int offset, int limit, string name)
        {
            var _user = _userService.GetAllUsers(offset, limit, name);
            var _userCount = _userService.TotalRecord(name);
            if (_user.Any())
            {
                return Ok(new { users = _user, totalCount = _userCount });
            }
            return Ok(new { users = _user, totalCount = 0 });
        }

        [HttpGet(nameof(GetUser))]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUser(id);
            if (user != null)
            {
                return Ok(user);
            }
            return BadRequest(new { errorMessage = CustomMessage.NO_RECORD_FOUND });
        }


    }
}
