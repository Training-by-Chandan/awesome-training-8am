using System;
using System.Collections.Generic;

namespace Ecom.Web.ViewModels
{
    public class SessionViewModel
    {
        public SessionViewModel()
        {
            this.Products = new List<ProductSessionViewModel>();
        }
        public List<ProductSessionViewModel> Products { get; set; }
    }
    public class ProductSessionViewModel
    {
        public Guid ProductId { get; set; }
        public string ProductName { get;set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string FilePath { get; set; }
    }
}