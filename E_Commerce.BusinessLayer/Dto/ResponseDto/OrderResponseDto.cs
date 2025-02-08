using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Dto.ResponseDto
{
    public class OrderResponseDto
    {
        public int orderId { get; set; }

        public string cargoCompanyName { get; set; }

        public string statuDescription { get; set; }

        public string customerName { get; set; }

        public string customerLastName { get; set; }

        public string customerAddress { get; set; }

    }

}
