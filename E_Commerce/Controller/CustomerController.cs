using Azure.Messaging;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Entities;
using E_Commerce.ResponseDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce.Controller
{
    [Route("[controller]")]
    [ApiController] //Atılan isteklerde herhangi bir hata meydana gelirse api controller problem detail nesnesine bu hatayı yazar ve bize döndürür.Kendi Api Attributelarımızıda yazabiliriz.

    public class CustomerController : ControllerBase
    {


        // GET: api/<ValuesController>
        [HttpGet]
        [Route("getcustomers")]
        public List<Customer> getCustomers()
        {
            E_CommerceDbContext db = new E_CommerceDbContext();

            return db.Customers.ToList();
        }

        [HttpGet]
        [Route("getcustomerbyid/{customerId}")]
        public IActionResult getCustomerById(int customerId)
        {
            E_CommerceDbContext db = new E_CommerceDbContext();

            var headers = Request.Headers;
            var body = Request.Body;
            var Request_path = Request.Path;
            var Request_route = Request.RouteValues;

            var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerId);

            if (customer != null)
            {
                return Ok(customer);
            }

            //return BadRequest(new ResponseDto { message = $"Kullanıcı bulunamadı.{customer.CustomerID}" });
            //return StatusCode(500,new ResponseDto() { message = "Customer bulunamadı."});
            //return StatusCode(500,JsonConvert.SerializeObject("Server hatası"));
            return NotFound(new {Message = "Customer not found"});

        }


        [HttpPost]
        [Route("addcustomer")]
        public IActionResult addCustomer(Customer customer)
        {


            E_CommerceDbContext db = new E_CommerceDbContext();

            if (!ModelState.IsValid) {
                return BadRequest(new {Message = "Kullanıcı eklenemedi."});
            }
            else
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return Ok("Kullanıcı Kaydedildi");
            }

        }
    }
}
