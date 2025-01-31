using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Services
{
    public class ProductService : IProductService
    {
     
        E_CommerceDbContext _context;

        public ProductService(E_CommerceDbContext context)
        {
          
            _context = context;
        }

        public void addProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product getProductById(int productId)
        {
            return _context.Products.FirstOrDefault(x => x.productId == productId);
        }

        public List<Product> getProducts()
        {
          return _context.Products.ToList();
        }
    }
}
