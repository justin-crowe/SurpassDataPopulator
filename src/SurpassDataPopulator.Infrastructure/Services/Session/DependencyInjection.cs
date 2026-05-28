using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SurpassDataPopulator.Application.Interfaces.Services;

namespace SurpassDataPopulator.Infrastructure.Services.Session;

public static class DependencyInjection
{
    public static IServiceCollection AddSessionManager(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ISessionManager, SessionManager>();
        return services;
    }
}