using EngineerToolPack.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace EngineerToolPack.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;    
        }
    }
}
