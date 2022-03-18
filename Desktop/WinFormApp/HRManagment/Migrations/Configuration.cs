namespace HRManagment.Migrations
{
    using HRManagment.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HRManagment.Context.DefaultContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HRManagment.Context.DefaultContext db)
        {
            if (!db.UserInfos.Any(p => p.Username == "admin@admin.com"))
            {
                var adminUser = new UserInfo() { Username = "admin@admin.com", Password = "Admin@123", UserType = UserType.Admin };
                db.UserInfos.Add(adminUser);
                db.SaveChanges();
            }
        }
    }
}