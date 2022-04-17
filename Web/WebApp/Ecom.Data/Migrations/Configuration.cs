namespace Ecom.Data.Migrations
{
    using Ecom.Web.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ecom.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ecom.Web.Models.ApplicationDbContext db)
        {
            var roleStore = new RoleStore<IdentityRole>(db);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            if (!(db.Roles.Any(p => p.Name == StrConst.Roles.Admin)))
            {
                roleManager.Create(new IdentityRole() { Name = StrConst.Roles.Admin });
            }
            if (!(db.Roles.Any(p => p.Name == StrConst.Roles.Customer)))
            {
                roleManager.Create(new IdentityRole() { Name = StrConst.Roles.Customer });
            }

            if (!(db.Users.Any(u => u.UserName == "admin@admin.com")))
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "admin@admin.com", PhoneNumber = "12345678911", Email = "admin@admin.com" };
                userManager.Create(userToInsert, "Admin@123");

                userManager.AddToRole(userToInsert.Id, StrConst.Roles.Admin);
            }

            if (!(db.Users.Any(u => u.UserName == "customer@customer.com")))
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "customer@customer.com", PhoneNumber = "12345678911", Email = "customer@customer.com" };
                userManager.Create(userToInsert, "Customer@123");

                userManager.AddToRole(userToInsert.Id, StrConst.Roles.Customer);
            }
        }
    }
}