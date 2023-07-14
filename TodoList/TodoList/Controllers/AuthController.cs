using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.Business.Abstract;
using TodoList.Model;
using TodoList.Model.Dto;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;
        public AuthController( IAuthService authService)
        {
                _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(UserForLogin user)
        {
            var userCheck = _authService.Login(user);

            if (userCheck==null)
            {
                return BadRequest();
            }

            var token=_authService.CreateToken(userCheck);
            return Ok(token);
        }

        [HttpPost("register")]
        public IActionResult Register(UserForRegister user)
        {
            var userCheck = _authService.Register(user);

            if (userCheck == null)
            {
                return BadRequest();
            }
            if (!userCheck.Success)
            {
                return BadRequest();
            }
            
            return Ok(userCheck.Data);
        }
    }
}
