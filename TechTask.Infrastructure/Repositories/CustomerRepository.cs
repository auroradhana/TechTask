using TechTask.Domain.Models;
using TechTask.Domain.Interfaces;
using TechTask.Infrastructure.Context;

namespace TechTask.Infrastructure.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(TechTaskDbContext context) : base(context) { }
    }
}
