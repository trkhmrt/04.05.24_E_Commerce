using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {


        [HttpGet]
        [Route("createOrder")]
        public void createOrderByBasketId(int basketId)
        {

        }



    }
}
