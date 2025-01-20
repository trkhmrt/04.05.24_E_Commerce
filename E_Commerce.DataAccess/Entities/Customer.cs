using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class Customer
    {
        public int customerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
      
        public string Email { get; set; }
        public string Password { get; set; }

        public int ActiveAddressID { get; set; }

        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        public int ActivateStatusID { get; set; }



       
    }
}
