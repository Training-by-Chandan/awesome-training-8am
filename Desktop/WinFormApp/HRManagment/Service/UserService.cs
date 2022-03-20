using HRManagment.Context;
using HRManagment.Models;
using HRManagment.Repository;
using HRManagment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Service
{
    public class UserService
    {
        private UserRepository userRepository = new UserRepository();

        public (bool, string) Login(LoginViewModel model)
        {
            try
            {
                var existing = userRepository.GetByUserName(model.Username);
                if (existing != null)
                {
                    if (existing.Password == model.Password)
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

        public (bool, string) CreateUser(RegisterUserViewModel model)
        {
            try
            {
                var existing = userRepository.GetByUserName(model.Username);
                if (existing != null)
                {
                    return (false, "User already exists");
                }
                var user = model.ConvertToUserInfo();

                return userRepository.CreateUser(user);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public List<UserInfoViewModel> GetAll()
        {
            return userRepository.GetAllUSers().Select(p => new UserInfoViewModel() { Id = p.Id, Username = p.Username, UserType = p.UserType }).ToList();
        }
    }
}