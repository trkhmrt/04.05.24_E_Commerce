using E_Commerce.BusinessLayer.Dto.RequestDto;
using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.JwtService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService _authService;
        private readonly JwtGenerator _jwtGenerator;

        public AuthController(JwtGenerator jwtGenerator,IAuthService authService)
        {
            _jwtGenerator = jwtGenerator;
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var login_user = _authService.login(loginDto);

            var token = _jwtGenerator.GenerateToken(login_user.userEmailToken , login_user.userRolesToken);

            return Ok(new { JwtToken = token });

        }


    }
}
