using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MyApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure
{
    public static class DependencyInjectionInfas
    {
        public static IServiceCollection AddInfastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-NPDET1D\\SQLEXPRESS01; Database=NeoDB; Trusted_Connection=True; MultipleActiveResultSets=True; TrustServerCertificate=True");
            });
            return services;
        }
    }
}
