using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public UserType UserType { get; set; }
        public string PasswordHash { get; set; }
    }

    public enum UserType
    {
        Employee,
        Manager,
        Admin
    }
}