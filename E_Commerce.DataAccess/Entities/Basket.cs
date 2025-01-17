using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class Basket
    {
        public int BasketID { get; set; }

        public int UserID { get; set; }

        public int TotalPrice { get; set; }

        public int TotalQuantity { get; set; }

        public string CouponCode { get; set; }

        public int TaxID { get; set; }




    }
}
