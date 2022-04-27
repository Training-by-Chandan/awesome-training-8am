using Ecom.Web.Models;
using System;

namespace Ecom.Web.ViewModels
{
    public class OrderViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string Address { get; set; }
    }
}