using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.BusinessLayer.Dto.RequestDto;
using E_Commerce.BusinessLayer.Dto.ResponseDto;
using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Context;

namespace E_Commerce.BusinessLayer.Services
{
    public class AuthService:IAuthService
    {
        IUserRolesService _userRolesService;
        IUserService _userService;
        
        E_CommerceDbContext _context;

        public AuthService(IUserRolesService userRolesService, IUserService userService, E_CommerceDbContext context)
        {
            _userRolesService = userRolesService;
            _userService = userService;
            _context = context;
          
        }

        public UserDto login(LoginDto loginDto)
        {
            List<String> role_names =new  List<String>();

            var user = _context.Users.FirstOrDefault(u=>u.userEmail == loginDto.userMail);

            var founded_user_roles_id = _context.UserRoles.Where(ur => ur.UserId == user.userId).Select(rid=>rid.RoleId).ToList();


            foreach (var role_id  in founded_user_roles_id)
            {
                var role = _context.Roles.FirstOrDefault(r=>r.roleId==role_id);
                role_names.Add(role.roleName);
            }


            UserDto userDto = new UserDto()
            {
                userEmailToken = user.userEmail,
                userRolesToken = role_names
            };



            return userDto;
        }
    }
}
