using E_Commerce.BusinessLayer.ResponseDto;
using E_Commerce.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Interfaces
{
    public interface IBasketService
    {

        BasketReponseDto addBasket(List<ProductDto> products,int customerId);
        List<Basket> getBaskets();
        BasketReponseDto getBasketByBasketId(int basketId);
        BasketReponseDto getBasketByCustomerId(int customerId);
        bool changeBasketStatus(BasketStatusChangeDto basketStatusChangeDto);
      



    }
}
