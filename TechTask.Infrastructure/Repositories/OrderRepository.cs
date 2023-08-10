using Microsoft.EntityFrameworkCore;
using TechTask.Domain.Interfaces;
using TechTask.Domain.Models;
using TechTask.Infrastructure.Context;

namespace TechTask.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(TechTaskDbContext context) : base(context) { }

        public override async Task<List<Order>> GetAll() => await Db.Orders.AsNoTracking().Include(b => b.Customer)
            .OrderBy(b => b.Id)
            .ToListAsync();
    }
}
