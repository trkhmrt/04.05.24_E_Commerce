using E_Commerce.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Extensions
{
    public static class SeedDataCreator
    {
        public static void SeedDataCreate(this ModelBuilder modelBuilder)
        {
            #region Customer
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    customerId = 34790,
                    ActivateStatusID = 1,
                    FirstName = "Ali",
                    LastName = "Veli",
                    UserName = "aliveli",
                    Email = "aliveli@gmail.com",
                    Password = "123456",
                    ActiveAddressID = 1
                },
                new Customer
                {
                    customerId = 43125,
                    ActivateStatusID = 1,
                    FirstName = "Tarık",
                    LastName = "Hamarat",
                    UserName = "trkhmrt",
                    Email = "trkhamarat@gmail.com",
                    Password = "123456",
                    ActiveAddressID = 1
                }
                );
            #endregion
            #region Status
            modelBuilder.Entity<Status>().HasData(

                new Status
                {
                    statusId = 1,
                    statusDescription = "User Active"
                }
                );
            #endregion
            #region BasketStatus
            modelBuilder.Entity<BasketStatus>().HasData(

                new BasketStatus
                {
                    basketStatusId = 1,
                    basketStatusDescription = "Basket Active"
                },
                 new BasketStatus
                 {
                     basketStatusId = 2,
                     basketStatusDescription = "Basket Ready for Payment"
                 },
                  new BasketStatus
                  {
                      basketStatusId = 3,
                      basketStatusDescription = "Basket Canceled"
                  },
                   new BasketStatus
                   {
                       basketStatusId = 4,
                       basketStatusDescription = "Basket Paid"
                   }


                );
            #endregion
            #region OrderStatus
            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus
                {
                    orderStatusId = 1,
                    statusName = "Order Active"
                },
                 new OrderStatus
                 {
                     orderStatusId = 2,
                     statusName = "Order Canceled"
                 },
                  new OrderStatus
                  {
                      orderStatusId = 3,
                      statusName = "Order Preparing"
                  },
                  new OrderStatus
                  {
                      orderStatusId = 4,
                      statusName = "Order On The Way"
                  },
                  new OrderStatus
                  {
                      orderStatusId = 5,
                      statusName = "Order Delivered"
                  }
                );
            #endregion
            #region Basket
            modelBuilder.Entity<Basket>().HasData(
                new Basket
                {
                    BasketID = 9000,
                    customerId = 34790,
                    TotalPrice = 100,
                    TotalQuantity = 1,
                    CouponCode = "",
                    TaxID = 1 ,
                    basketStatusId = 1
                },
                 new Basket
                 {
                     BasketID = 9002,
                     customerId = 43125,
                     TotalPrice = 300,
                     TotalQuantity = 1,
                     CouponCode = "",
                     TaxID = 1,
                     basketStatusId = 1
                 }
                );
            #endregion
            #region BasketDetail
            modelBuilder.Entity<BasketDetail>().HasData(
                new BasketDetail
                {
                    basketDetailId = 2000,
                    basketId = 9000,
                    productName = "Oduncu Gömlek",
                    productPrice = 100,
                    productQuantity = 1,
                    categoryId = 1,
                    productId = 1400
                },
                new BasketDetail
                {
                    basketDetailId = 2002,
                    basketId = 9002,
                    productName = "Su geçirmez Bot",
                    productPrice = 100,
                    productQuantity = 1,
                    categoryId = 2,
                    productId = 1720
                }
                );
            #endregion
            #region Product
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    productId=1400,
                    productName = "Gömlek",
                    productPrice = 100,
                    productDescription = "Ouncu Gömlek",
                    productImage = "Product 1 Image",
                    categoryId = 1,
                    subCagetory = 1
                },
                new Product
                {
                    productId = 1720,
                    productName = "Ayakkabı",
                    productPrice = 100,
                    productDescription = "Su geçirmez ayakkabı",
                    productImage = "Product 1 Image",
                    categoryId = 2,
                    subCagetory = 2
                }
            );
            #endregion
            #region Category
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                   categoryId = 1,
                   categoryName = "Üst Giyim"

                },
                new Category
                {
                   categoryId = 2,
                   categoryName = "Ayakkabı"
                }
            );
            #endregion
            #region SubCategory
            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory
                {
                    subCategoryId = 1,
                    subCategoryName = "Gömlek",
                    subcategoryCategoryId = 1
                },
                new SubCategory
                {
                    subCategoryId = 2,
                    subCategoryName = "Bot",
                    subcategoryCategoryId = 2
                }
            );
            #endregion
        }
    }
}


/*
 
10-> 10 id li kişinin aktifte sepeti var mı ?

-E Aktif sepet id içine ekleme yap

H-Kişi için yeni sepet oluştur.
 
Bu ikim durumdada ürün eklendiğinde silindiğinde tek bir sepet id içine ürünler eklenip silincek.

Eğer sepet için sepeti onayla butonuna basılırsa sepetin statüsü onaylandıya geçecek.





 
 */