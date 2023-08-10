using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTask.Domain.Interfaces;

namespace TechTask.Domain.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

        public void Dispose() => _customerRepository?.Dispose();
    }
}
