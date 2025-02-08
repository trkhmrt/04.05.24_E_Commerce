using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.DataAccess.Entities;

namespace E_Commerce.BusinessLayer.Dto.RequestDto
{
    public class OrderRequestDto
    {

        public  int customerId { get; set; }
        public int cargoCompanyId {  get; set; }
        



    }
}
