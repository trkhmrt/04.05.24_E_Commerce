using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Entities
{
    public class Address
    {

        public int AddressID { get; set; }
        public string Country { get; set; }
        public string District { get; set; }
        public string DoorNo { get; set; }
        public string ApartmentNo { get; set; }
        public int ProvinceID { get; set; }


    }
}
