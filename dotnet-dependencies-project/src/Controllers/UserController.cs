using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using dotnet_dependencies_project.Models;
using dotnet_dependencies_project.Services;

namespace dotnet_dependencies_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User data is null.");
            }

            var result = await _userService.CreateUser(user);
            if (result)
            {
                return Ok("User registered successfully.");
            }

            return BadRequest("User registration failed.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}