using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.BusinessLayer.Dto.RequestDto;
using E_Commerce.BusinessLayer.Dto.ResponseDto;
using E_Commerce.BusinessLayer;

namespace E_Commerce.BusinessLayer.Interfaces
{
    public interface IAuthService
    {


        UserDto login(LoginDto loginDto);
    }
}
