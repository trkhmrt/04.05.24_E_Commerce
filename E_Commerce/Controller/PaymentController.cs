using E_Commerce.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }


        [HttpGet]
        [Route("createPayment")]
        public void createPayment(int customerId)
        {
            _paymentService.createPayment(customerId);
        }





    }
}
