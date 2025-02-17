using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Dto.ResponseDto
{
    public class UserDto
    {
        public string userEmailToken { get; set; }
        public List<String> userRolesToken { get; set; }

    }
}
