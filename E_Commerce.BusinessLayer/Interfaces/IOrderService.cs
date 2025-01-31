using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Interfaces
{
    public interface IOrderService
    {
        void createOrderBycustomerId(int customerId);


    }
}
