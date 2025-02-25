using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace E_Commerce.InFrustracture.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class SecondMiddleware
    {
        private readonly RequestDelegate _next;

        public SecondMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async  Task Invoke(HttpContext httpContext,ILogService logService)
        {
            try
            {
             await _next(httpContext);
            }
            catch(Exception e)
            {
                logService.createLog(new Log { createDate = DateTime.Now, logDescription = e.Message, logType = 5, requestPath = httpContext.Request.Path });


             
            }



            
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class SecondMiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseSecondMiddleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<SecondMiddleware>();
    //    }
    //}
}
