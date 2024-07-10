using EngineerToolPack.Application.Services.Authentication.Commands;
using EngineerToolPack.Application.Services.Authentication.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace EngineerToolPack.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationCommandService, AuthenticationCommandService>();
            services.AddScoped<IAuthenticationQueryService, AuthenticationQueryService>();

            return services;    
        }
    }
}
