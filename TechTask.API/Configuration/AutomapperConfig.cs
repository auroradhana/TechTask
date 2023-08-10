using AutoMapper;
using TechTask.API.Dtos.Order;
using TechTask.API.Dtos.Product;
using TechTask.Domain.Models;

namespace TechTask.API.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Product, ProductResultDto>().ReverseMap();
            CreateMap<Order, OrderAddDto>().ReverseMap();
            CreateMap<Order, OrderResultDto>().ReverseMap();
        }
    }
}
