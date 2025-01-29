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
    public class OrderService : IOrderService
    {
        E_CommerceDbContext _context;
        IBasketService _basketService;
        IPaymentService _paymentService;


        public OrderService(IBasketService basketService,IPaymentService paymentService,E_CommerceDbContext context)
        {
            _basketService = basketService;
            _paymentService = paymentService;
            _context = context;
        }

        public void createOrderByBasketId(int customerId)
        {
             var founded_basket = _context.Baskets.FirstOrDefault(b => b.customerId == customerId);

            var founded_payment = _context.Payments.LastOrDefault(p => p.customerId == customerId);



            if(founded_basket != null)
            {
                Order order = new Order()
                {
                    BasketID = founded_basket.BasketID,
                    PaymentID = founded_payment.paymentId,
                    StatusID = 1,
                    CargoCompanyID = 1,
                    

                   
                };





            }

        }
    }
}
