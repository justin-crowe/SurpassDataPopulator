using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Infrastructure.Configuration;
using SurpassDataPopulator.Infrastructure.Http;

namespace SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi;

public static class DependencyInjection
{
    public static IServiceCollection AddOpenTriviaApi(this IServiceCollection services, IConfiguration configuration)
    {
        var configSection = AppSettings.MapConfigSection<OpenTriviaApiOptions>(configuration, OpenTriviaApiOptions.ConfigSectionName, out var options);
            
        services.Configure<OpenTriviaApiOptions>(configSection)
            .AddRefitClient<IOpenTriviaApi>()
            .ConfigureHttpClient(x =>
            {
                x.BaseAddress = new Uri(options.BaseUrl);
            })
#if DEBUG
            .AddHttpMessageHandler<HttpLoggingHandler>()
#endif
            ;
            
        services.AddSingleton<IItemGeneratorService, OpenTriviaApiService>();
        return services;
    }
}