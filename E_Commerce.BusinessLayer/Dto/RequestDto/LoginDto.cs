using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Dto.RequestDto
{
    public class LoginDto
    {
        public string userMail { get; set; }
        public string password { get; set; }
    }
}
