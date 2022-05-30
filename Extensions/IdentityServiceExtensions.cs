using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ClientApi.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services, 
            IConfiguration config)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(option =>
                     {
                            option.TokenValidationParameters = new TokenValidationParameters
                            {
                                 ValidateIssuerSigningKey = true,
                                 IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"])),
                                 ValidateIssuer = false,
                                 ValidateAudience = false,
                            };
                     });

            return services;
        }
    }
}
                     