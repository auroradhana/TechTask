using TechTask.Domain.Models;

namespace TechTask.Domain.Interfaces
{
    public interface IProductService : IDisposable
    {
        Task<IEnumerable<Product>> GetAll();
    }
}
