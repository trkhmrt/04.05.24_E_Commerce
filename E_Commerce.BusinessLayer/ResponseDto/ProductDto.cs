using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.ResponseDto
{
    public class ProductDto 
    {
        public int productId { get; set; }
        public int categoryId { get; set; }
        public int productPrice { get; set; }
        public int productQuantity { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public int discountValue { get; set; }
        public int subCagetory { get; set; }
        public int taxId { get; set; }
        public string productImage { get; set; }
    }
}
