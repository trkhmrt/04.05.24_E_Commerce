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
    public class PaymentService : IPaymentService
    {
        E_CommerceDbContext _context;
        IBasketService _basketService;
        public PaymentService(E_CommerceDbContext context,IBasketService basketService)
        {
            _context = context;
            _basketService = basketService;
        }



        public void createPayment(int customerId)
        {
             var founded_basket = _context.Baskets.FirstOrDefault(b => b.customerId == customerId);

            var customer_cardNumber = 999999999;

           

            Payment payment = new Payment()
            {
               cardNumber = customer_cardNumber,
                customerId = customerId,
                paymentAmount = founded_basket.TotalPrice,
            };


            founded_basket.basketStatusId = 4;

            _context.Baskets.Update(founded_basket);
            _context.Payments.Add(payment);
            _context.SaveChanges();



        }
    }
}
