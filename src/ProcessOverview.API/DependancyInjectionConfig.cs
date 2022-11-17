using ProcessOverview.Domain.Interfaces;
using ProcessOverview.Domain.Services;
//using ProcessOverview.Infrastructure.Context;
//using ProcessOverview.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using ProcessOverview.Infrastructure.Context;

namespace ProcessOverview.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ProcessOverviewDbContext>();

            
            services.AddScoped<IProcessRepository>();

            
            services.AddScoped<IProcessService, ProcessService>();

            return services;
        }
    }
}