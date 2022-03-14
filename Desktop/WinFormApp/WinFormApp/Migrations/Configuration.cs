namespace WinFormApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WinFormApp.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<WinFormApp.Context.CurrentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WinFormApp.Context.CurrentContext db)
        {
            if (!db.UserInfo.Any(p => p.Username == "admin@admin.com"))
            {
                var adminUser = new UserInfo() { Username = "admin@admin.com", Password = "Admin@123", UserTypes = UserType.Admin };
                db.UserInfo.Add(adminUser);
                db.SaveChanges();
            }
        }
    }
}