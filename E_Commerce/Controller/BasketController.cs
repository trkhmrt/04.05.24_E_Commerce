﻿using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {

        IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }


        [HttpGet]
        [Route("getBaskets")]
        public IActionResult getBaskets()
        {
            var baskets = _basketService.getBaskets();
            return Ok(baskets);
        }



        [HttpGet]
        [Route("getBasketByBasketId/{basketId}")]
        public IActionResult getBasketByBasketId(int basketId)
        {
            var basket = _basketService.getBasketByBasketId(basketId);

            if (basket.Basket == null)
            {
                return NotFound(basket);
            }

            return Ok(basket);
        }



        [HttpGet]
        [Route("getBasketByCustomerId/{customerId}")]
        public IActionResult getBasketByCustomerId(int customerId)
        {
            var basket = _basketService.getBasketByCustomerId(customerId);

            if (basket.Basket == null)
            {
                return NotFound(basket);
            }

            return Ok(basket);
        }



        [HttpPost]
        [Route("addBasket/{customerId}")]
        public IActionResult addBasket(List<Product> products,int customerId)
        {
            var basket = _basketService.addBasket(products,customerId);

            if (basket.Basket == null)
            {
                return NotFound(basket);
            }

            return Ok(basket);
        }





    }
}
