using HRManagment.Models;

namespace HRManagment.ViewModels
{
    public class RegisterUserViewModel : LoginViewModel
    {
        public UserType UserType { get; set; }

        public UserInfo ConvertToUserInfo()
        {
            return new UserInfo()
            {
                Username = this.Username,
                Password = this.Password,
                UserType = this.UserType
            };
        }
    }
}