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

        [HttpGet]
        [Route("createOrder/{customerId}")]
        public void createOrderBycustomerId(int customerId)
        {
            _orderService.createOrderBycustomerId(customerId);
        }



    }
}
