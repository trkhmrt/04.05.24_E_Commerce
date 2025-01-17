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
            //#region Customer
            //modelBuilder.Entity<Customer>().HasData(
            //    new Customer
            //    {
            //        CustomerID = 1,
            //        ActivateStatusID = 1,
            //        FirstName = "Ali",
            //        LastName = "Veli",
            //        UserName = "aliveli",
            //        Email = "trkhamarat@gmail.com",
            //        Password = "123456",
            //        ActiveAddressID = 1
            //    }




            //    );
            //#endregion
            //#region Status
            //modelBuilder.Entity<Status>().HasData(

            //    new Status
            //    {
            //        statusId= 1,
            //        statusDescription = "User Active"
            //    }
            //    );
            //#endregion
            #region Basket
            //modelBuilder.Entity<Basket>().HasData(
            //    new Basket
            //    {
            //        BasketID = 1,
            //        UserID = 1,
            //        TotalPrice = 100,
            //        TotalQuantity = 1,
            //        CouponCode = "123",
            //        TaxID = 1
            //    },
            //     new Basket
            //     {
            //         BasketID = 2,
            //         UserID = 1,
            //         TotalPrice = 100,
            //         TotalQuantity = 1,
            //         CouponCode = "123",
            //         TaxID = 1
            //     },
            //      new Basket
            //      {
            //          BasketID = 3,
            //          UserID = 1,
            //          TotalPrice = 100,
            //          TotalQuantity = 1,
            //          CouponCode = "123",
            //          TaxID = 1
            //      }
            //    );
            #endregion


        }
    }
    }
