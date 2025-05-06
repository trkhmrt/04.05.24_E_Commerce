using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.BusinessLayer.Dto.RequestDto;

namespace E_Commerce.BusinessLayer.Interfaces
{
    public interface IPaymentService
    {

        public void createPayment(CheckOutDto checkOutDto);



    }
}
