using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class Coupon
    {
        public int CouponID { get; set; }
        public int CouponCode { get; set; }
        public int CouponDescription { get; set; }
    }
}
