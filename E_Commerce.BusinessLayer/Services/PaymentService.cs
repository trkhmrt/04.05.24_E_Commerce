using E_Commerce.BusinessLayer.Interfaces;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.BusinessLayer.Dto.RequestDto;

namespace E_Commerce.BusinessLayer.Services
{
    public class PaymentService : IPaymentService
    {
        E_CommerceDbContext _context;
        IOrderService _orderService;
        
        public PaymentService(E_CommerceDbContext context,IOrderService orderService)
        {
            _context = context;
            _orderService = orderService;
        }



        public void createPayment(CheckOutDto checkOutDto)
        {
             var founded_basket = _context.Baskets.FirstOrDefault(b => b.customerId == checkOutDto.customerId);
             
            Payment newPayment = new Payment()
            {
                cardNumber = checkOutDto.cardNumber,
                customerId = checkOutDto.customerId,
                paymentAmount = founded_basket.TotalPrice,
                basketId = checkOutDto.basketId,
            };
            
            
            
            
            founded_basket.basketStatusId = 4;
            _context.Baskets.Update(founded_basket);
            _context.Payments.Add(newPayment);
            _context.SaveChanges();

           
            
            _orderService.createOrder(new OrderRequestDto
            {
                payment = newPayment,
            });
        }
    }
}
