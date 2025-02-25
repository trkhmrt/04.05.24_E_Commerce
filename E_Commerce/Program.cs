
using System.Text;
using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.BusinessLayer.Services;
using E_Commerce.DataAccess.Context;
using E_Commerce.InFrustracture.Extensions;
using E_Commerce.InFrustracture.Middleware;
using E_Commerce.JwtService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace E_Commerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddServices();
            builder.Services.AddDbContext<E_CommerceDbContext>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Buradaki bilgileri appsettings.json dan tanımladık ve buraya çektik.
            //Configuration sayesinde appsettings.json içindeki veriler kullanılabilir.
            var jwtKey = builder.Configuration["Jwt:Key"];
            var jwtIssuer = builder.Configuration["Jwt:Issuer"];
            var jwtAudience = builder.Configuration["Jwt:Audience"];


            //Jwt nin AuthenticationScheme'sı sisteme dahil edildi.Hangi parametrelerle token valid edilecek bunları belirledik.
            //Atılan her istekte buradaki middleware çalışacak
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(option =>
            {
                option.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,  // Tokenı kim üretti
                    ValidateAudience = true, //Token hangi sistemde kullanılabilir.
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtIssuer,
                    ValidAudience =  jwtAudience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey)),
                    ClockSkew = TimeSpan.Zero
                };

            });

            builder.Services.AddSingleton<JwtGenerator>();
           

            var app = builder.Build();

            app.UseMiddleware<FirstMiddleware>();
            app.UseMiddleware<SecondMiddleware>();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
