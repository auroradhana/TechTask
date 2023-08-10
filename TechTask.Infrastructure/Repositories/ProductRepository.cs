using TechTask.Domain.Interfaces;
using TechTask.Domain.Models;
using TechTask.Infrastructure.Context;

namespace TechTask.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(TechTaskDbContext context) : base(context) { }

    }
}
