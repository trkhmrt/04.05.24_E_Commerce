using E_Commerce.BusinessLayer.Dto.RequestDto;
using E_Commerce.BusinessLayer.Dto.ResponseDto;
using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
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
        
        [HttpGet]
        [Route("addProductToBasket/{basketId}/{productId}")]
        public IActionResult addProductToBasket(int basketId, int productId)
        {
            _basketService.addProductToBasket(basketId, productId);
            return Ok();
        }
        
        [HttpPost]
        [Route("changeBasketStatus")]
        public IActionResult changeBasketStatus(BasketStatusChangeDto basketStatusDto)
        {
            try
            {
                return Ok(_basketService.changeBasketStatus(basketStatusDto));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        [HttpGet]
        [Route("getBasketDetailsByCustomerId/{customerId}")]
        public IActionResult getBasketDetailsByCustomerId(int customerId)
        {

            var basketDetails = _basketService.getBasketDetailsByCustomerId(customerId);

            if (basketDetails.Count == 0)
            {
                return NotFound(basketDetails);
            }

            return Ok(basketDetails);

        }

        [HttpGet]
        [Route("getBasketDetailsByBasketId/{basketId}")]
        public IActionResult getBasketDetailsByBasketId(int basketId)
        {
            var basketDetails = _basketService.getBasketDetailsByBasketId(basketId);
            return Ok(basketDetails);
        }
        
        [HttpPost]
        [Route("deleteProductToBasketByProductId")]
        public IActionResult deleteProductToBasketByProductId(BasketProductDeleteDto basketProductDeleteDto)
        {

            if (_basketService.deleteProductToBasketByProductId(basketProductDeleteDto))
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
