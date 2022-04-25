using System;

namespace Ecom.Web.ViewModels
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string FilePath { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}