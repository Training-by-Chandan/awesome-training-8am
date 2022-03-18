using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Model;

namespace WinFormApp.Context
{
    public class CurrentContext : DbContext
    {
        public CurrentContext() : base("name=Default")
        {
        }

        #region DbSet Properties

        public DbSet<Student> Students { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }

        #endregion DbSet Properties
    }
}