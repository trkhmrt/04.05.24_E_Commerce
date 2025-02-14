using E_Commerce.BusinessLayer.Dto.RequestDto;
using E_Commerce.BusinessLayer.Dto.ResponseDto;
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

        void addBasket(List<ProductDto> products,int customerId);
        List<Basket> getBaskets();
        BasketReponseDto getBasketByBasketId(int basketId);
        BasketReponseDto getBasketByCustomerId(int customerId);
        bool changeBasketStatus(BasketStatusChangeDto basketStatusChangeDto);

        List<BasketDetail> getBasketDetailsByCustomerId(int customerId);

        bool deleteProductToBasketByProductId(BasketProductDeleteDto basketProductDeleteDto);



    }
}
