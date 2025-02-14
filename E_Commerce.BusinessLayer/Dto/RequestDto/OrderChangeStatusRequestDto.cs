using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Dto.RequestDto
{
    public class OrderChangeStatusRequestDto
    {
        public int orderId { get; set; }

        public int orderStatusId { get; set; }

    }
}
