using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce.Controller
{
    [Route("[controller]")]
    [ApiController]
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

        [HttpPost]
        [Route("addcustomer")]
        public string addCustomer(Customer customer)
        {
            E_CommerceDbContext db = new E_CommerceDbContext();

            if(customer == null) {
                return "Customer is null";
            }
            else
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return "Customer added successfully";
            }

        }
    }
}
