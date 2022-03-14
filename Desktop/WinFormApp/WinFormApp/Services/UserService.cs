using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Context;

namespace WinFormApp.Services
{
    public class UserService
    {
        private CurrentContext db = new CurrentContext();

        public (bool, string) Login(string username, string password)
        {
            try
            {
                var existing = db.UserInfo.FirstOrDefault(p => p.Username == username);
                if (existing != null)
                {
                    if (existing.Password == password)
                    {
                        return (true, "Loggedin Successfully");
                    }
                    else
                    {
                        return (false, "Password does not match");
                    }
                }
                else
                {
                    return (false, "User not found");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}