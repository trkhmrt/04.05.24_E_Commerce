using E_Commerce.BusinessLayer.Dto.RequestDto;
using E_Commerce.BusinessLayer.Dto.ResponseDto;
using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
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

        public void addBasket(List<ProductDto> products,int customerId) 
        {
          
            var founded_basket = _context.Baskets.FirstOrDefault(b => b.customerId == customerId && b.basketStatusId == 1);

            if (founded_basket != null)
            {
                /*
                 BasketId
                 */
                List<ProductDto> basket_products = new List<ProductDto>();
              

                basket_products.AddRange(products);
               
                var founded_basket_details = _context.BasketDetails.Where(bd => bd.basketId == founded_basket.BasketID).ToList();

                var totalprice = 0;
               
                for (int i = 0; i < founded_basket_details.Count; i++) 
                {
                    for(int j = 0; j< basket_products.Count; j++)
                    {
                        if (founded_basket_details[i].productId == basket_products[j].productId)
                        {
                            founded_basket_details[i].productQuantity += basket_products[j].productQuantity;
                            
                            
                            _context.BasketDetails.Update(founded_basket_details[i]);
                            _context.SaveChanges();

                            basket_products.RemoveAt(j);
                        }
                    
                    }

                   


                    if (basket_products.Count == 0)
                    {
                       
                        break;
                    }
                }


                for (int j = 0; j < basket_products.Count; j++)
                {
                    BasketDetail basketDetail = new BasketDetail()
                    {
                        basketId = founded_basket.BasketID,
                        productId = basket_products[j].productId,
                        categoryId = basket_products[j].categoryId,
                        productQuantity = basket_products[j].productQuantity,
                        productPrice = basket_products[j].productPrice,
                        productName = basket_products[j].productName,

                    };

                    _context.BasketDetails.Add(basketDetail);
                    _context.SaveChanges();
                }

                var basketQuantityPrice = calculateBasketPriceQuantity(customerId);

                founded_basket.TotalQuantity = basketQuantityPrice.basketTotalQuantity;
                founded_basket.TotalPrice = basketQuantityPrice.basketTotalPrice;
                _context.Baskets.Update(founded_basket);
                _context.SaveChanges();




            }
         
        }

        public bool changeBasketStatus(BasketStatusChangeDto basketStatusChangeDto)
        {

            // ProcessId 1 -> Approve basket  ProccessId 2 -> Cancel basket 
            var founded_basket = _context.Baskets.FirstOrDefault(b => b.customerId == basketStatusChangeDto.customerId && b.basketStatusId == 1);


            if (basketStatusChangeDto.proccessTypeId == 1)
            {
                founded_basket.basketStatusId = 2;
            }
            else if(basketStatusChangeDto.proccessTypeId == 2)
            {
                founded_basket.basketStatusId = 3;
            }


            _context.Baskets.Update(founded_basket);
            _context.SaveChanges();

            return true;



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

        public List<BasketDetail> getBasketDetailsByCustomerId(int customerId)
        {

            var founded_basket = _context.Baskets.FirstOrDefault(b => b.customerId == customerId && b.basketStatusId == 1);

            if(founded_basket == null)
            {
                return new List<BasketDetail>();
            }

            var founded_basket_detail = _context.BasketDetails.Where(bd => bd.basketId == founded_basket.BasketID).ToList();


            return founded_basket_detail;
        }

        public BasketQuantityPriceDto calculateBasketPriceQuantity(int customerId)
        {
            int totalPrice = getBasketDetailsByCustomerId(customerId).Sum(bd=>bd.productQuantity*bd.productPrice);
            int totalQuantity = getBasketDetailsByCustomerId(customerId).Sum(bd => bd.productQuantity);

            BasketQuantityPriceDto basketQuantityPriceDto = new BasketQuantityPriceDto()
            {
                basketTotalPrice = totalPrice,
                basketTotalQuantity = totalQuantity,
            };

            return basketQuantityPriceDto;
        }

        public bool deleteProductToBasketByProductId(BasketProductDeleteDto basketProductDeleteDto)
        {
            var founded_basket = _context.Baskets.FirstOrDefault(b=>b.BasketID == basketProductDeleteDto.basketId && b.customerId==basketProductDeleteDto.customerId && b.basketStatusId==1);

            if (founded_basket != null)
            {
                var founded_basket_detail = _context.BasketDetails.FirstOrDefault(bd => bd.basketId == founded_basket.BasketID && basketProductDeleteDto.basketDetailId == bd.basketDetailId);
                
                
                var basketQuantityPriceDto = calculateBasketPriceQuantity(basketProductDeleteDto.customerId);

                founded_basket.TotalPrice = basketQuantityPriceDto.basketTotalPrice;
                founded_basket.TotalQuantity = basketQuantityPriceDto.basketTotalQuantity;

                _context.Baskets.Update(founded_basket);
                _context.BasketDetails.Remove(founded_basket_detail);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
