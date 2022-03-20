using HRManagment.Context;
using HRManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Repository
{
    public class UserRepository
    {
        private DefaultContext db = new DefaultContext();

        public UserInfo GetByUserName(string username)
        {
            return db.UserInfos.FirstOrDefault(p => p.Username == username);
        }

        public (bool, string) CreateUser(UserInfo user)
        {
            try
            {
                db.UserInfos.Add(user);
                db.SaveChanges();
                return (true, "Added Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public IQueryable<UserInfo> GetAllUSers()
        {
            return db.UserInfos.AsQueryable();
        }
    }
}