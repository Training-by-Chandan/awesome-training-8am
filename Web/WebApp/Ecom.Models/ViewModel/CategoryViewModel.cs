using System;
using System.ComponentModel.DataAnnotations;

namespace Ecom.Web.Models
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; } = new Guid();

        public string Name { get; set; }
        public string Description { get; set; }
    }
}