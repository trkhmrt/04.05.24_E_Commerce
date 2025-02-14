using E_Commerce.BusinessLayer.Dto.RequestDto;
using E_Commerce.BusinessLayer.Dto.ResponseDto;
using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controller
{

    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        [Route("createOrder")]
        public void createOrderBycustomerId(OrderRequestDto orderRequestDto)
        {
            _orderService.createOrderBycustomerId(orderRequestDto);
        }

        [HttpGet]
        [Route("getAllOrderByCustomerId")]
        public List<OrderResponseDto> getAllOrderByCustomerId(int customerId)
        {
            return _orderService.getAllOrderByCustomerId(customerId);
        }


        [HttpPost]
        [Route("changeOrderStatus")]
        public IActionResult changeOrderStatus(OrderChangeStatusRequestDto orderChangeStatusRequestDto)
        {
            var order = _orderService.changeOrderStatus(orderChangeStatusRequestDto);

            if (order != null)
            {
                return Ok(order);
            }

            return NotFound(order);
            
       
        }


    }
}
