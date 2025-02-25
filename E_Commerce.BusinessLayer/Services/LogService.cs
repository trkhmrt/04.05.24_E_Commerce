using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Services
{
    public class LogService : ILogService
    {
        E_CommerceDbContext _context;

        public LogService(E_CommerceDbContext context)
        {
            _context = context;
        }

        public void createLog(Log log)
        {

            _context.Logs.Add(log);
            _context.SaveChanges();

        }
    }
}
