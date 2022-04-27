using Ecom.Data;
using Ecom.Web.Models;

namespace Ecom.Repository
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
    }

    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}