using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class Role
    {
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }

        public ICollection<UserRole> userRoles { get; set; }
    }
}
