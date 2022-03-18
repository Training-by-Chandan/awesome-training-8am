using HRManagment.Context;
using HRManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Service
{
    public class UserService
    {
        private DefaultContext db = new DefaultContext();

        public (bool, string) Login(string username, string password)
        {
            try
            {
                var existing = db.UserInfos.FirstOrDefault(p => p.Username == username);
                if (existing != null)
                {
                    if (existing.Password == password)
                    {
                        Singleton.Instance.IsLoggedIn = true;
                        Singleton.Instance.Username = existing.Username;
                        Singleton.Instance.UserType = existing.UserType;
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

        public (bool, string) CreateUser(string username, string password, UserType userType)
        {
            try
            {
                var existing = db.UserInfos.FirstOrDefault(p => p.Username == username);
                if (existing != null)
                {
                    return (false, "User already exists");
                }
                var user = new UserInfo();
                user.Username = username;
                user.Password = password;
                user.UserType = userType;

                db.UserInfos.Add(user);
                db.SaveChanges();
                return (true, "Added Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}