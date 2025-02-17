using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.BusinessLayer.Services;
using E_Commerce.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static E_Commerce.BusinessLayer.Services.UserService;

namespace E_Commerce.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        IUserService _userService;
        IUserRolesService _userRolesService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

      
    }
}
