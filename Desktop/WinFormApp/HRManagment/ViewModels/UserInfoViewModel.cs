using HRManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.ViewModels
{
    public class UserInfoViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public UserType UserType { get; set; }
    }
}