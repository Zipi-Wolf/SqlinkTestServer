using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SqlinkTest.Interfaces;
using SqlinkTest.Models;
using SqlinkTest.Models.Dto;
using System.Threading.Tasks;

namespace SqlinkTest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private readonly ILoginService _loginService;

        public LoginController(IConfiguration config, ILoginService loginService)
        {
            _config = config;
            _loginService = loginService;
        }
        [AllowAnonymous]
        [ActionName("Login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest login)
        {
            IActionResult response = Unauthorized();
            var user = await _loginService.AuthenticateUser(login);

            if (user != null)
            {
                var tokenString = _loginService.GenerateJSONWebToken();
                response = Ok(new LoginResponse
                {
                    Token = tokenString,
                    personalDetails =new User { id = user.id, name = user.name, team = user.team, joinedAt = user.joinedAt, avatar = user.avatar }
                });
            }

            return response;
        }

    }

}

