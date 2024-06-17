using EngineerToolPack.Application.Common.Interfaces.Authentication;
using EngineerToolPack.Application.Common.Interfaces.Persistence;
using EngineerToolPack.Application.Common.Services;
using EngineerToolPack.Infrastructure.Authentication;
using EngineerToolPack.Infrastructure.Persistence;
using EngineerToolPack.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EngineerToolPack.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
