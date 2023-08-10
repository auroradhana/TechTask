using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTask.Domain.Models;

namespace TechTask.Domain.Interfaces
{
    public interface IOrderService : IDisposable
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order> Add(Order order);
    }
}
