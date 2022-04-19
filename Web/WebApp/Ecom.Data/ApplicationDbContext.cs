using System.Data.Entity;
using Ecom.Web.Models;
using Ecom.Web.ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Ecom.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Category> Categories { get; set; }
    }
}