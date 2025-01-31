using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class Payment
    {
        public int paymentId { get; set; }

        public int paymentAmount { get; set; }

        public int customerId { get; set; }

        public int cardNumber { get; set; }

        public int basketId { get; set; }




    }
}
