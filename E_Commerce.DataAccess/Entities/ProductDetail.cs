using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class ProductDetail
    {
        public int productDetailId { get; set; }
        public int productId { get; set; }
        public string productColor { get; set; }
        public string productSize { get; set; }
        public int productStockQuantity { get; set; }
        
    }
}
