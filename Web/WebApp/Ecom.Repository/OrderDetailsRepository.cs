using Ecom.Data;
using Ecom.Web.Models;

namespace Ecom.Repository
{
    public interface IOrderDetailsRepository : IBaseRepository<OrderDetails>
    {
    }

    public class OrderDetailsRepository : BaseRepository<OrderDetails>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}