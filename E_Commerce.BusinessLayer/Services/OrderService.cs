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
        IBasketService _basketService;
        IPaymentService _paymentService;
       

        public OrderService(IBasketService basketService,IPaymentService paymentService,E_CommerceDbContext context)
        {
            _basketService = basketService;
            _paymentService = paymentService;
            _context = context;
        }

        public void createOrderBycustomerId(OrderRequestDto orderRequestDto)
        {
             var founded_basket = _context.Baskets.FirstOrDefault(b => b.customerId == orderRequestDto.customerId && b.basketStatusId==2);

            if (founded_basket != null)
            {
                var founded_basket_details = _context.BasketDetails.Where(bd => bd.basketId == founded_basket.BasketID).ToList();

                Payment payment = new Payment();

                payment.customerId = orderRequestDto.customerId;
                payment.cardNumber = 123456789;
                payment.basketId = founded_basket.BasketID;
                payment.paymentAmount = founded_basket_details.Sum(x => x.productQuantity * x.productPrice);


                _context.Payments.Add(payment);
                _context.SaveChanges();



                Order order = new Order();

                
                order.PaymentID = payment.paymentId;
                order.BasketID = founded_basket.BasketID;
                order.StatusID = 1;
                order.CargoCompanyID = orderRequestDto.cargoCompanyId;

                founded_basket.basketStatusId = 4; //Basket Paid'e çekildi.


                _context.Baskets.Update(founded_basket);
                _context.Orders.Add(order);
                _context.SaveChanges();



                foreach (var item in founded_basket_details)
                {
                    OrderDetail orderDetail = new OrderDetail()
                    {
                        OrderID = order.OrderID,
                        ProductAmount = item.productPrice,
                        ProductID = item.productId

                    };

                    _context.OrderDetails.Add(orderDetail);
                }

                _context.SaveChanges();
                
               



              



            }





        }

        public List<OrderResponseDto> getAllOrderByCustomerId(int customerId)
        {
            var founded_customer = _context.Customers.FirstOrDefault(c => c.customerId == customerId);

            if (founded_customer != null)
            {
                var founded_customer_orders = _context.Orders.Where(o => o.customerId == customerId).ToList();

                if (founded_customer_orders != null)
                {
                    foreach (var item in founded_customer_orders)
                    {
                        OrderResponseDto orderResponseDto = new OrderResponseDto()
                        {
                            cargoCompanyName = CargoCompanyDictionary.kargoSirketleri.FirstOrDefault(c => c.Key == item.CargoCompanyID).Value
                        };

                        


                    }

                }


            }

            return null;
        }
    }
}
