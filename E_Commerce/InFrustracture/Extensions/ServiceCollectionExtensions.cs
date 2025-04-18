﻿using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.BusinessLayer.Services;

namespace E_Commerce.InFrustracture.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddServices(this IServiceCollection services) {

            //services.AddScoped<IProductService, ProductService>();
            //services.AddScoped<ICategoryService, CategoryService>();
            //services.AddScoped<IBasketDetailService, BasketDetailService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IOrderService, OrderService>(); 
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRolesService, UserRolesService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ILogService, LogService>();


            return services;
        } 
    }
}
