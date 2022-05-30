using ClientApi.Data;
using ClientApi.Interfaceses;
using ClientApi.Services;
using Microsoft.EntityFrameworkCore;

namespace ClientApi.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(option =>
            {
                option.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            return services;    
        }
    }
}
                 