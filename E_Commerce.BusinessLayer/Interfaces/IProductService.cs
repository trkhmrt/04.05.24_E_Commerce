using E_Commerce.DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Interfaces
{
    public interface IProductService
    {
        void addProduct(Product product);

        List<Product> getProducts();

        Product getProductById(int productId);

        

    }
}
