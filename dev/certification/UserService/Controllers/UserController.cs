using Microsoft.AspNetCore.Mvc;
using UserService.Services;
using UserService.Dtos;

namespace UserService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public IActionResult Register(UserDto userDto)
        {
            var result = _userService.Register(userDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(UserDto userDto)
        {
            var result = _userService.Authenticate(userDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return Unauthorized(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var result = _userService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

