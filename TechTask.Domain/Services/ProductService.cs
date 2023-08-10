using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTask.Domain.Interfaces;
using TechTask.Domain.Models;

namespace TechTask.Domain.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAll() => await _productRepository.GetAll();

        public void Dispose() => _productRepository?.Dispose();
    }
}
