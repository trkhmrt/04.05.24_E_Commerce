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
        
        public void addProductToBasket(int basketId, int productId)
        {
            List<BasketDetail> foundedBasketDetails = _context.BasketDetails.Where(b => b.basketId == basketId).ToList();
            
            var duplicateProduct = foundedBasketDetails.Exists(b => b.productId == productId);
            if (duplicateProduct)
            {
                foundedBasketDetails.Find(b => b.productId == productId).productQuantity++;
            }
            else
            {
                Product product = _context.Products.FirstOrDefault(p => p.productId == productId);
                
                BasketDetail basketDetail = new BasketDetail
                {
                    basketId = basketId,
                    productId = productId,
                    productName = product.productName,
                    productQuantity = 1,
                    productPrice = product.productPrice,
                    categoryId = product.categoryId,
                };
            
                _context.BasketDetails.Add(basketDetail);
            }
            _context.SaveChanges();
        }

        public bool changeBasketStatus(BasketStatusChangeDto basketStatusDto)
        {

            // ProcessId 1 -> Approve basket  ProccessId 2 -> Cancel basket 
            var foundedBasket = _context.Baskets.FirstOrDefault(b => b.BasketID == basketStatusDto.basketId);

            if (foundedBasket != null)
            {
                if (basketStatusDto.proccessTypeId == 2)
                {
                    foundedBasket.basketStatusId = 2;
                }
                else if (basketStatusDto.proccessTypeId == 1)
                {
                    foundedBasket.basketStatusId = 1;
                }
                _context.Baskets.Update(foundedBasket);
                _context.SaveChanges();
                return true;
            }

            throw new Exception("Active Basket not found");

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

        public BasketDetailDto getBasketDetailsByBasketId(int basketId)
        {
            int foundedBasketStatusId = _context.Baskets.FirstOrDefault(b => b.BasketID == basketId).basketStatusId;
            List <BasketDetail> foundedBasketDetails = _context.BasketDetails.Where(b => b.basketId == basketId).ToList();

            return new BasketDetailDto
            {
                basketStatusId = foundedBasketStatusId,
                BasketDetails = foundedBasketDetails
            };

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
