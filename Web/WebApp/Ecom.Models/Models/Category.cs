using System;
using System.ComponentModel.DataAnnotations;

namespace Ecom.Web.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}