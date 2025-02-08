using E_Commerce.BusinessLayer.Dto.RequestDto;
using E_Commerce.BusinessLayer.Interfaces;
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
        [Route("/createOrder")]
        public void createOrderBycustomerId(OrderRequestDto orderRequestDto)
        {
            _orderService.createOrderBycustomerId(orderRequestDto);
        }

        [HttpGet]
        public void getAllOrderByCustomerId(int customerId)
        {
            _orderService.getAllOrderByCustomerId(customerId);
        }





    }
}
