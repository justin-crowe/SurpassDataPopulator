using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SurpassDataPopulator.Application.Interfaces.Services;

namespace SurpassDataPopulator.Infrastructure.Services.FileStorage;

public static class DependencyInjection
{
    public static IServiceCollection AddFileStorage(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IFileStorage, FileStorage>();
        return services;
    }
}