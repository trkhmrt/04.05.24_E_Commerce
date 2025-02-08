using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.BusinessLayer.Dto.RequestDto;
using E_Commerce.BusinessLayer.Dto.ResponseDto;
using E_Commerce.DataAccess.Entities;

namespace E_Commerce.BusinessLayer.Interfaces
{
    public interface IOrderService
    {
        void createOrderBycustomerId(OrderRequestDto orderRequestDto);
        List<OrderResponseDto> getAllOrderByCustomerId(int customerId);




    }
}
