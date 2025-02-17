using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class User
    {
        public int userId { get; set; }
        public string userPassword { get; set; }
        public string userEmail { get; set; }

        public ICollection<UserRole> userRoles { get; set; }



    }
}
