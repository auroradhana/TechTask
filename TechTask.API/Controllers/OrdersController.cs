using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechTask.API.Dtos.Order;
using TechTask.Domain.Interfaces;
using TechTask.Domain.Models;

namespace TechTask.API.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : MainController
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IMapper mapper,
            IOrderService orderService)
        {
            _mapper = mapper;
            _orderService = orderService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _orderService.GetAll();

            return Ok(_mapper.Map<IEnumerable<OrderResultDto>>(orders));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add(OrderAddDto orderDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var order = _mapper.Map<Order>(orderDto);
            var orderResult = await _orderService.Add(order);

            if (orderResult == null) return BadRequest();

            return Ok(_mapper.Map<OrderResultDto>(orderResult));
        }
    }
}
