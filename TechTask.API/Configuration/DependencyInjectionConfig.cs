using TechTask.Domain.Interfaces;
using TechTask.Domain.Services;
using TechTask.Infrastructure.Context;
using TechTask.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace TechTask.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<TechTaskDbContext>();

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
