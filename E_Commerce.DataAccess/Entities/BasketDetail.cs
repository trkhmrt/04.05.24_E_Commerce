using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class BasketDetail
    {
        public int basketDetailId { get; set; }
        public int basketId { get; set; }
        public string productName { get; set; }
        public int productPrice { get; set; }
        public int productQuantity { get; set; }
        public int categoryId { get; set; }
        public int productId { get; set; }
    }
}
