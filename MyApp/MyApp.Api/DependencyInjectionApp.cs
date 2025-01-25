using MyApp.Application;
using MyApp.Infrastructure;

namespace MyApp.Api
{
    public static class DependencyInjectionApp
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI()
                .AddInfastructureDI(configuration);
            return services;
        }
    }
}
