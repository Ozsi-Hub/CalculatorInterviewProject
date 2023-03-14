using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CalculatorInterview.BLL.Abstraction;
using CalculatorInterview.BLL.Service;

namespace CalculatorInterview.BLL
{
    public static class ServiceProviderExtension
    {
        public static IServiceCollection AddLogicServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(ServiceProviderExtension));
            services.AddScoped<ICalculatorService, CalculatorService>();

            return services;
        }
    }
}
