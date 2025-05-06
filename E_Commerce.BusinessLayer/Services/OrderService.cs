using E_Commerce.BusinessLayer.Dto.RequestDto;
using E_Commerce.BusinessLayer.Dto.ResponseDto;
using E_Commerce.BusinessLayer.Enums;
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
        
        public OrderService(E_CommerceDbContext context)
        {
            _context = context;
        }

        public void createOrder(OrderRequestDto orderRequestDto)
        {
            var founded_basket_details = _context.BasketDetails
                .Where(bd => bd.basketId == orderRequestDto.payment.basketId).ToList();

            using (var transaction = _context.Database.BeginTransaction())
            {
                Order order = new Order
                {
                    BasketID = orderRequestDto.payment.basketId,
                    PaymentID = orderRequestDto.payment.paymentId,
                    StatusID = 1,
                    customerId = orderRequestDto.payment.customerId,
                    CargoCompanyID = 1
                };
               
                _context.Orders.Add(order);
                _context.SaveChanges();
                
                List<OrderDetail> orderDetails = new List<OrderDetail>();

                foreach (var item in founded_basket_details)
                {
                    OrderDetail orderDetail = new OrderDetail()
                    {
                        OrderID = order.OrderID,
                        ProductAmount = item.productPrice,
                        ProductID = item.productId
                    };

                    orderDetails.Add(orderDetail);
                }

                _context.OrderDetails.AddRange(orderDetails);
                _context.SaveChanges();
                transaction.Commit();

            }
        }
    }
}


