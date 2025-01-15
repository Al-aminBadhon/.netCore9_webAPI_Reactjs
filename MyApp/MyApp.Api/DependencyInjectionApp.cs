using MyApp.Application;
using MyApp.Infrastructure;

namespace MyApp.Api
{
    public static class DependencyInjectionApp
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
                .AddInfastructureDI();
            return services;
        }
    }
}
