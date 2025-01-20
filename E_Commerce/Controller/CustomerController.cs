using Azure.Messaging;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Entities;
using E_Commerce.ResponseDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce.Controller
{
    [Route("[controller]")]
    [ApiController] //Atılan isteklerde herhangi bir hata meydana gelirse api controller problem detail nesnesine bu hatayı yazar ve bize döndürür.Kendi Api Attributelarımızıda yazabiliriz.

    public class CustomerController : ControllerBase
    {


        


    }
}
