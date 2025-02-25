using E_Commerce.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using E_Commerce.DataAccess.Entities;
using E_Commerce.DataAccess.Context;
namespace E_Commerce.InFrustracture.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;
      

        public FirstMiddleware(RequestDelegate next)
        {
            _next = next;
          
        }

        public async Task Invoke(HttpContext httpContext,ILogService logService)
        {
           

            if (httpContext.Request.Path.StartsWithSegments("/product/getAllProducts"))
            {
                //httpContext.Response.Redirect("/Basket/getBasketByBasketId/9000");

                //httpContext.Response.StatusCode = StatusCodes.Status403Forbidden;
                //httpContext.Response.ContentType = "application/json";
                //await httpContext.Response.WriteAsync("Bu sayfaya erişim izni yoktur.");

                logService.createLog(new Log { createDate = DateTime.Now , logDescription = "Yasaklı Adrese gidildi" , logType = 4 , requestPath = httpContext.Request.Path});


                return;
            }



            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class FirstMiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseFirstMiddleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<FirstMiddleware>();
    //    }
    //}
}
