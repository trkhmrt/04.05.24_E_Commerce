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


        [Authorize(Roles ="Customer,User")]
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
        public IActionResult addBasket(List<ProductDto> products, int customerId)
        {

            try
            {
                _basketService.addBasket(products, customerId);
                return Ok(new { successMessage = "Ürünler Sepete Eklendi." });
            }

            catch (Exception e)
            {
                return BadRequest(new { errorMessage = "Baskete eklenirken hata oluştu." });
            }



        }



        [HttpPost]
        [Route("changeBasketStatus")]
        public IActionResult changeBasketStatus(BasketStatusChangeDto basketStatusChangeDto)
        {
            var basket = _basketService.changeBasketStatus(basketStatusChangeDto);

            if (basket)
            {
                return NotFound(basket);
            }

            return Ok(basket);
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
