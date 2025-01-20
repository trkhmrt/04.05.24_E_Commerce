using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.BusinessLayer.ResponseDto;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Services
{
    /*
     
        1	Basket Active
        2	Basket Ready for Payment
        3	Basket Canceled
     */
    public class BasketService : IBasketService
    {
        E_CommerceDbContext _context;

        public BasketService(E_CommerceDbContext context)
        {
            _context = context;
        }

        public BasketReponseDto addBasket(List<Product> products,int customerId)
        {
            var founded_basket = _context.Baskets.FirstOrDefault(b => b.customerId == customerId && b.basketStatusId == 1);

            if (founded_basket != null)
            {
                /*
                 BasketId
                 */

                var counter = 0;

                var founded_basket_details = _context.BasketDetails.Where(bd => bd.basketId == founded_basket.BasketID).ToList();

                for (int i = 0; i < founded_basket_details.Count; i++)
                {
                    if(founded_basket_details[i].productId == products[i].productId)
                    {
                        founded_basket_details[i].productQuantity += 1;
                        _context.BasketDetails.Update(founded_basket_details[i]);
                        _context.SaveChanges();
                    }
                }

           




                return null;
            }
            else
            {
                return null;
            }



        }

        public BasketReponseDto getBasketByBasketId(int basketId)
        {
            BasketReponseDto basketReponseDto = new BasketReponseDto();
            var founded_basket = _context.Baskets.FirstOrDefault(b => b.BasketID == basketId);

            if (founded_basket != null)
            {
               
                basketReponseDto.Basket = founded_basket;
                basketReponseDto.message = "Basket founded successfully";   
            }
            else
            {
                basketReponseDto.Basket = null;
                basketReponseDto.message = "Basket not founded";
            }


            return basketReponseDto;
        }

        public BasketReponseDto getBasketByCustomerId(int customerId)
        {
            BasketReponseDto basketReponseDto = new BasketReponseDto();

            var founded_basket = _context.Baskets.FirstOrDefault(b => b.customerId == customerId);



            if (founded_basket != null)
            {

                basketReponseDto.Basket = founded_basket;
                basketReponseDto.message = "Basket founded successfully";
            }
            else
            {
                basketReponseDto.Basket = null;
                basketReponseDto.message = "Basket not founded";
            }

            return basketReponseDto;

        }

        public List<Basket> getBaskets()
        {
           return _context.Baskets.ToList();
        }
    }
}
