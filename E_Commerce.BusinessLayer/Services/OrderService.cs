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

        public void createOrderBycustomerId(int customerId)
        {
             var founded_basket = _context.Baskets.FirstOrDefault(b => b.customerId == customerId && b.basketStatusId==2);

            if (founded_basket != null)
            {
                var founded_basket_details = _context.BasketDetails.Where(bd => bd.basketId == founded_basket.BasketID).ToList();

                Payment payment = new Payment();

                payment.customerId = customerId;
                payment.cardNumber = 123456789;
                payment.basketId = founded_basket.BasketID;
                payment.paymentAmount = founded_basket_details.Sum(x => x.productQuantity * x.productPrice);


                _context.Payments.Add(payment);
                _context.SaveChanges();



                Order order = new Order();

                
                order.PaymentID = payment.paymentId;
                order.BasketID = founded_basket.BasketID;
                order.StatusID = 1;
                order.CargoCompanyID = 1;

                founded_basket.basketStatusId = 4; //Basket Paid'e çekildi.


                _context.Baskets.Update(founded_basket);
                _context.Orders.Add(order);



                _context.SaveChanges();



            }





        }
    }
}
