using Ecom.Data;
using Ecom.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Ecom.Repository
{
    public interface IUserRepository
    {
    }

    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext db;

        public UserRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        //public ApplicationUser GetUserById()
        //{
        //    var store = new UserStore<ApplicationUser>(db);
        //    var manager = new applicationUserManager
        //}
    }
}