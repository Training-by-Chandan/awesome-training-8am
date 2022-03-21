namespace HRManagment.Migrations
{
    using HRManagment.Common;
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
                var adminUser = new UserInfo() { Username = "admin@admin.com", UserType = UserType.Admin };
                adminUser.PasswordHash = Hasher.HashPassword("Admin@123");
                db.UserInfos.Add(adminUser);
                db.SaveChanges();
            }

            #region Hash Existing Password

            //var users = db.UserInfos.ToList();
            //foreach (var item in users)
            //{
            //    item.PasswordHash = Hasher.HashPassword(item.Password);
            //    db.Entry(item).State = EntityState.Modified;
            //    db.SaveChanges();
            //}

            #endregion Hash Existing Password
        }
    }
}