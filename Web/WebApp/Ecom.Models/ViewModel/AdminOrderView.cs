using Ecom.Web.Models;
using System;

namespace Ecom.Web.ViewModels
{
    public class AdminOrderViewModel
    {
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public OrderStatus Status { get; set; }
        public double TotalAmount { get; set; }
    }
}