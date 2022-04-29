using Ecom.Repository;
using Ecom.Web.Models;
using Ecom.Web.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Services
{
    public interface IOrderService
    {
        (bool, string) AddOrder(SessionViewModel model, string address, string userId);

        List<AdminOrderViewModel> GetOrderList();
    }

    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderDetailsRepository orderDetailsRepository;
        private readonly IMapper mapper;

        public OrderService(
            IOrderRepository orderRepository,
            IOrderDetailsRepository orderDetailsRepository,
            IMapper mapper
            )
        {
            this.orderDetailsRepository = orderDetailsRepository;
            this.orderRepository = orderRepository;
            this.mapper = mapper;
        }

        public (bool, string) AddOrder(SessionViewModel model, string address, string userId)
        {
            try
            {
                if (model == null || model.Products.Count == 0) return (false, "Cart is empty");

                var order = new Order()
                {
                    Id = System.Guid.NewGuid(),
                    Address = address,
                    OrderDate = System.DateTime.Now,
                    OrderStatus = OrderStatus.Ordered,
                    UserId = userId
                };
                var res = orderRepository.Create(order);
                if (res.Item1)
                {
                    //orderdetails
                    foreach (var item in model.Products)
                    {
                        var details = new OrderDetails()
                        {
                            Id = System.Guid.NewGuid(),
                            OrderId = order.Id,
                            ProductId = item.ProductId,
                            Quantity = item.Quantity
                        };
                        var detRes = orderDetailsRepository.Create(details);
                    }
                    return (true, "Order Placed Successfully");
                }
                return (false, res.Item2);
            }
            catch (System.Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                return (false, ex.Message);
            }
        }

        public List<AdminOrderViewModel> GetOrderList()
        {
            try
            {
                var data = orderRepository.GetAll().Select(p => new AdminOrderViewModel
                {
                    OrderId = p.Id,
                    CustomerName = p.User.FirstName + " " + p.User.LastName,
                    //CusstomerEmail = p.User.
                    Status = p.OrderStatus,
                    TotalAmount = p.OrderDetails.Sum(x => x.Quantity * x.Product.Price)
                });
                return data.ToList();
            }
            catch (System.Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                return new List<AdminOrderViewModel>();
            }
        }
    }
}