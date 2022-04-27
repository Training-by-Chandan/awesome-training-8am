using System;

namespace Ecom.Web.ViewModels
{
    public class OrderDetailsViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid OrderId { get; set; }
        public virtual ProductViewModel Product { get; set; }
        public int Quantity { get; set; }
    }
}