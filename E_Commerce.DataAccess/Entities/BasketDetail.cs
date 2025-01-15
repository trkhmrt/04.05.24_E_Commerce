using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class BasketDetail
    {
        public int BasketDetailID { get; set; }
        public int BasketID { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductQuantity { get; set; }
        public string CategoryID { get; set; }
    }
}
