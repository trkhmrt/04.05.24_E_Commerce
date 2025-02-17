using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.DataAccess.Entities;

namespace E_Commerce.BusinessLayer.Interfaces
{
    public interface IUserRolesService
    {
        List<UserRole> GetUserRoles();
    }
}
