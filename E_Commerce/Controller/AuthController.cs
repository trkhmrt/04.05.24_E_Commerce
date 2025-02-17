using E_Commerce.JwtService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly JwtGenerator _jwtGenerator;

        public AuthController(JwtGenerator jwtGenerator)
        {
            _jwtGenerator = jwtGenerator;
        }

        [HttpPost("login")]
        public IActionResult Login(string username)
        {

            var token = _jwtGenerator.GenerateToken(username , new List<string> { "Admin","User" });


            return Ok(new { JwtToken = token });

        }


    }
}
