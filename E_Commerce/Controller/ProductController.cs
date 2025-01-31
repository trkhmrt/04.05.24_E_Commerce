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
        [Route("getAllProducts")]
        public List<Product> getAllProducts()
        {
            return _productService.getProducts();
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




    }
}
