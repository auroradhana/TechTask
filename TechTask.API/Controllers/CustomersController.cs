using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechTask.Domain.Interfaces;

namespace TechTask.API.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : MainController
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomersController(IMapper mapper,
            ICustomerService customerService)
        {
            _mapper = mapper;
            _customerService = customerService;
        }
    }
}
