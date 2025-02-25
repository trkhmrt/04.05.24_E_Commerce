using E_Commerce.BusinessLayer.Dto.RequestDto;
using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Entities;
using E_Commerce.JwtService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace E_Commerce.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService _authService;
        ILogService _logService;
        private readonly JwtGenerator _jwtGenerator;

        public AuthController(JwtGenerator jwtGenerator,IAuthService authService, ILogService logService)
        {
            _jwtGenerator = jwtGenerator;
            _authService = authService;
            _logService = logService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var login_user = _authService.login(loginDto);

            if(login_user!=null)
            {

                var token = _jwtGenerator.GenerateToken(login_user.userEmailToken, login_user.userRolesToken);

                _logService.createLog(new Log { createDate = DateTime.Now,logDescription = $"User Token={token}",requestPath = HttpContext.Request.Path , logType = 2 });

                return Ok(new { JwtToken = token });
            }

            _logService.createLog(new Log { createDate = DateTime.Now, logDescription = $"Kullanıcı adı veya şifre hatalı...", requestPath = HttpContext.Request.Path, logType = 3 });

            return BadRequest("Kullanıcı adı veya şifre hatalı...");


            

        }


    }
}
