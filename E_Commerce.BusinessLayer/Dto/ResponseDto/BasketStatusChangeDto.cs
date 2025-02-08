using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Dto.ResponseDto
{
    public class BasketStatusChangeDto
    {
        public int customerId { get; set; }

        public int proccessTypeId { get; set; }
    }
}
