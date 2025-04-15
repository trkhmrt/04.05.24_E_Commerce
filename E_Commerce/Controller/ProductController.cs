using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("getProducts")]
        public IActionResult GetProducts()
        {
            return Ok(_productService.getProducts());
        }


        [HttpGet]
        [Route("getProductById/{productId}")]
        public Product getProductById(int productId)
        {
            return _productService.getProductById(productId);
        }


        [HttpPost]
        [Route("addProduct")]
        public void addProduct(Product product)
        {
            _productService.addProduct(product);
        }

        [HttpDelete]
        [Route("deleteProduct/{productId}")]
        public IActionResult deleteProduct(int productId)
        {
           if(_productService.deleteProduct(productId))
            {
                return Ok("Ürün silindi.");            
                    
            }

            return BadRequest("Ürün silinirken bir hata meydana geldi.!");

        }


    }
}
