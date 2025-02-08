using E_Commerce.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Dto.ResponseDto
{
    public class BasketReponseDto
    {
        public Basket Basket { get; set; }

        public string message { get; set; }

    }
}
