using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechTask.API.Dtos.Order;
using TechTask.API.Dtos.Product;
using TechTask.Domain.Interfaces;
using TechTask.Domain.Models;
using TechTask.Domain.Services;

namespace TechTask.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : MainController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IMapper mapper,
            IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProductResultDto>>(products));
        }
    }
}
