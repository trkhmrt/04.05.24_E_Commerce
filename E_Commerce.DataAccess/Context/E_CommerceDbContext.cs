using E_Commerce.DataAccess.Entities;
using E_Commerce.DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.Context
{
    public class E_CommerceDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-IBV340F\\FULLSTACKDB;Database=E-CommerceDb;Trusted_Connection=True;Encrypt=False");



            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            SeedDataCreator.SeedDataCreate(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<CargoCompany> CargoCompanies { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketDetail> BasketDetails { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Address> Addresses { get; set; }



    }
}
