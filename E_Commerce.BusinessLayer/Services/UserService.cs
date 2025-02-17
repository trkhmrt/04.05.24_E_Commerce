using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.BusinessLayer.Services
{
    public class UserService : IUserService
    {

        E_CommerceDbContext _context;

        public UserService(E_CommerceDbContext context)
        {
            _context = context;
        }

       

       
    }

   

   
}
