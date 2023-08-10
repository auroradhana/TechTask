using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTask.Domain.Interfaces;
using TechTask.Domain.Models;

namespace TechTask.Domain.Services
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> Add(Order order)
        {
            if (_orderRepository.Search(b => b.Id == order.Id).Result.Any())
                return null;

            await _orderRepository.Add(order);
            return order;
        }

        public async Task<IEnumerable<Order>> GetAll() => await _orderRepository.GetAll();

        public void Dispose() => _orderRepository?.Dispose();
    }
}