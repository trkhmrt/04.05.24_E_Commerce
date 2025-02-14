using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Dto.RequestDto
{
    public class BasketProductDeleteDto
    {
        public int basketId { get; set; }
        public int customerId { get; set; }
        public int productId { get; set; }

    }
}
