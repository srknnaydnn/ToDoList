using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.Business.Abstract;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getusers")]
        public IActionResult GetAllUsers()
        {
            var user=_userService.GetUsers();
            if (!user.Success)
            {
                return Ok(user);
            }
            return Ok(user);
        }
    }
}
