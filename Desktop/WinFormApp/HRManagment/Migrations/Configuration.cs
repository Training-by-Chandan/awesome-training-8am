namespace HRManagment.Migrations
{
    using HRManagment.Models;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography;

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

            #region Hash Existing Password

            var hasher = new PasswordHasher<UserInfo>();
            var users = db.UserInfos.Where(p => p.PasswordHash == null).ToList();
            foreach (var item in users)
            {
                item.PasswordHash = hasher.HashPassword(item, item.Password);
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }

            #endregion Hash Existing Password
        }
    }
}