﻿// <auto-generated />
using E_Commerce.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_Commerce.DataAccess.Migrations
{
    [DbContext(typeof(E_CommerceDbContext))]
    [Migration("20250217180059_userRoleTableAddedLater")]
    partial class userRoleTableAddedLater
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"));

                    b.Property<string>("ApartmentNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoorNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceID")
                        .HasColumnType("int");

                    b.HasKey("AddressID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Basket", b =>
                {
                    b.Property<int>("BasketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BasketID"));

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaxID")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.Property<int>("basketStatusId")
                        .HasColumnType("int");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.HasKey("BasketID");

                    b.ToTable("Baskets");

                    b.HasData(
                        new
                        {
                            BasketID = 9000,
                            CouponCode = "",
                            TaxID = 1,
                            TotalPrice = 100,
                            TotalQuantity = 1,
                            basketStatusId = 1,
                            customerId = 34790
                        },
                        new
                        {
                            BasketID = 9002,
                            CouponCode = "",
                            TaxID = 1,
                            TotalPrice = 300,
                            TotalQuantity = 1,
                            basketStatusId = 1,
                            customerId = 43125
                        });
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.BasketDetail", b =>
                {
                    b.Property<int>("basketDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("basketDetailId"));

                    b.Property<int>("basketId")
                        .HasColumnType("int");

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productPrice")
                        .HasColumnType("int");

                    b.Property<int>("productQuantity")
                        .HasColumnType("int");

                    b.HasKey("basketDetailId");

                    b.ToTable("BasketDetails");

                    b.HasData(
                        new
                        {
                            basketDetailId = 2000,
                            basketId = 9000,
                            categoryId = 1,
                            productId = 1400,
                            productName = "Oduncu Gömlek",
                            productPrice = 100,
                            productQuantity = 1
                        },
                        new
                        {
                            basketDetailId = 2002,
                            basketId = 9002,
                            categoryId = 2,
                            productId = 1720,
                            productName = "Su geçirmez Bot",
                            productPrice = 100,
                            productQuantity = 1
                        });
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.BasketStatus", b =>
                {
                    b.Property<int>("basketStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("basketStatusId"));

                    b.Property<string>("basketStatusDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("basketStatusId");

                    b.ToTable("BasketStatuses");

                    b.HasData(
                        new
                        {
                            basketStatusId = 1,
                            basketStatusDescription = "Basket Active"
                        },
                        new
                        {
                            basketStatusId = 2,
                            basketStatusDescription = "Basket Ready for Payment"
                        },
                        new
                        {
                            basketStatusId = 3,
                            basketStatusDescription = "Basket Canceled"
                        },
                        new
                        {
                            basketStatusId = 4,
                            basketStatusDescription = "Basket Paid"
                        });
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.CargoCompany", b =>
                {
                    b.Property<int>("CargoCompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CargoCompanyID"));

                    b.Property<string>("CargoCompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CargoCompanyID");

                    b.ToTable("CargoCompanies");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoryId"));

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("categoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            categoryId = 1,
                            categoryName = "Üst Giyim"
                        },
                        new
                        {
                            categoryId = 2,
                            categoryName = "Ayakkabı"
                        });
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Coupon", b =>
                {
                    b.Property<int>("CouponID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponID"));

                    b.Property<int>("CouponCode")
                        .HasColumnType("int");

                    b.Property<int>("CouponDescription")
                        .HasColumnType("int");

                    b.HasKey("CouponID");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("customerId"));

                    b.Property<int>("ActivateStatusID")
                        .HasColumnType("int");

                    b.Property<int>("ActiveAddressID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            customerId = 34790,
                            ActivateStatusID = 1,
                            ActiveAddressID = 1,
                            Email = "aliveli@gmail.com",
                            FirstName = "Ali",
                            LastName = "Veli",
                            Password = "123456",
                            UserName = "aliveli"
                        },
                        new
                        {
                            customerId = 43125,
                            ActivateStatusID = 1,
                            ActiveAddressID = 1,
                            Email = "trkhamarat@gmail.com",
                            FirstName = "Tarık",
                            LastName = "Hamarat",
                            Password = "123456",
                            UserName = "trkhmrt"
                        });
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Favorite", b =>
                {
                    b.Property<int>("FavoriteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavoriteID"));

                    b.Property<int>("FavoriteProductID")
                        .HasColumnType("int");

                    b.HasKey("FavoriteID");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("BasketID")
                        .HasColumnType("int");

                    b.Property<int>("CargoCompanyID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentID")
                        .HasColumnType("int");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailID"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductAmount")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.OrderStatus", b =>
                {
                    b.Property<int>("orderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("orderStatusId"));

                    b.Property<string>("statusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("orderStatusId");

                    b.ToTable("OrderStatuses");

                    b.HasData(
                        new
                        {
                            orderStatusId = 1,
                            statusName = "Order Active"
                        },
                        new
                        {
                            orderStatusId = 2,
                            statusName = "Order Canceled"
                        },
                        new
                        {
                            orderStatusId = 3,
                            statusName = "Order Preparing"
                        },
                        new
                        {
                            orderStatusId = 4,
                            statusName = "Order On The Way"
                        },
                        new
                        {
                            orderStatusId = 5,
                            statusName = "Order Delivered"
                        });
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Payment", b =>
                {
                    b.Property<int>("paymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("paymentId"));

                    b.Property<int>("basketId")
                        .HasColumnType("int");

                    b.Property<int>("cardNumber")
                        .HasColumnType("int");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<int>("paymentAmount")
                        .HasColumnType("int");

                    b.HasKey("paymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("productId"));

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<int>("discountValue")
                        .HasColumnType("int");

                    b.Property<string>("productDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productPrice")
                        .HasColumnType("int");

                    b.Property<int>("subCagetory")
                        .HasColumnType("int");

                    b.Property<int>("taxId")
                        .HasColumnType("int");

                    b.HasKey("productId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            productId = 1400,
                            categoryId = 1,
                            discountValue = 0,
                            productDescription = "Ouncu Gömlek",
                            productImage = "Product 1 Image",
                            productName = "Gömlek",
                            productPrice = 100,
                            subCagetory = 1,
                            taxId = 0
                        },
                        new
                        {
                            productId = 1720,
                            categoryId = 2,
                            discountValue = 0,
                            productDescription = "Su geçirmez ayakkabı",
                            productImage = "Product 1 Image",
                            productName = "Ayakkabı",
                            productPrice = 100,
                            subCagetory = 2,
                            taxId = 0
                        });
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.ProductDetail", b =>
                {
                    b.Property<int>("productDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("productDetailId"));

                    b.Property<string>("productColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<string>("productSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productStockQuantity")
                        .HasColumnType("int");

                    b.HasKey("productDetailId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Province", b =>
                {
                    b.Property<int>("provinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("provinceId"));

                    b.Property<string>("provinceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("provinceId");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Role", b =>
                {
                    b.Property<int>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("roleId"));

                    b.Property<string>("roleDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("roleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Status", b =>
                {
                    b.Property<int>("statusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("statusId"));

                    b.Property<string>("statusDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("statusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            statusId = 1,
                            statusDescription = "User Active"
                        });
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.SubCategory", b =>
                {
                    b.Property<int>("subCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("subCategoryId"));

                    b.Property<string>("subCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("subcategoryCategoryId")
                        .HasColumnType("int");

                    b.HasKey("subCategoryId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            subCategoryId = 1,
                            subCategoryName = "Gömlek",
                            subcategoryCategoryId = 1
                        },
                        new
                        {
                            subCategoryId = 2,
                            subCategoryName = "Bot",
                            subcategoryCategoryId = 2
                        });
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Tax", b =>
                {
                    b.Property<int>("taxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("taxId"));

                    b.Property<int>("taxValue")
                        .HasColumnType("int");

                    b.HasKey("taxId");

                    b.ToTable("Taxes");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<string>("userEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.UserRole", b =>
                {
                    b.HasOne("E_Commerce.DataAccess.Entities.Role", "Role")
                        .WithMany("userRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce.DataAccess.Entities.User", "User")
                        .WithMany("userRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.Role", b =>
                {
                    b.Navigation("userRoles");
                });

            modelBuilder.Entity("E_Commerce.DataAccess.Entities.User", b =>
                {
                    b.Navigation("userRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
