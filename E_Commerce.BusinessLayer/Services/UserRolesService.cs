using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Entities;

namespace E_Commerce.BusinessLayer.Services
{
    public class UserRolesService:IUserRolesService
    {
        E_CommerceDbContext _context;
    


        public UserRolesService(E_CommerceDbContext context)
        {
       
            _context = context;
        }


        public  List<UserRole> GetUserRoles()
        {

            List<UserRole> userRoles = _context.UserRoles.ToList();
            return userRoles;
        }
    }
}
