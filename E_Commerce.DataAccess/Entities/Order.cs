using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class Order
    {

        public int OrderID { get; set; }

        public int BasketID { get; set; }

        public int PaymentID { get; set; }

        public int StatusID { get; set; }

        public int customerId { get; set; }

        public int CargoCompanyID { get; set; }




    }
}
