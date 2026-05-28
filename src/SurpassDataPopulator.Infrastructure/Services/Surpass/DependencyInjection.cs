using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Infrastructure.Configuration;
using SurpassDataPopulator.Infrastructure.Http;
using SurpassDataPopulator.Infrastructure.Services.Credentials;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass;

public static class DependencyInjection
{
    public static IServiceCollection AddSurpassApi(this IServiceCollection services, IConfiguration configuration)
    {
        var configSection = AppSettings.MapConfigSection<SurpassApiOptions>(configuration, SurpassApiOptions.ConfigSectionName, out var options);

        var jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
        var refitSettings = new RefitSettings(new SystemTextJsonContentSerializer(jsonOptions));
        //See the SurpassApiServiceFactory for further refit setup as we need to set base address at runtime which cannot be done in the DI setup
        services
            .AddSingleton(refitSettings)
            .Configure<SurpassApiOptions>(configSection)
            .AddSingleton<ICredentialsStore, CredentialsStore>()
            //.AddTransient<CredentialsHandler>()
            .AddTransient<HttpLoggingHandler>();
        services
            .AddHttpClient(SurpassApiServiceFactory.HttpClientName)
#if DEBUG
            .AddHttpMessageHandler<HttpLoggingHandler>()
#endif
        ;
        services
            .AddTransient<ISurpassApiServiceFactory, SurpassApiServiceFactory>();
            //.AddTransient<ISurpassApiService, SurpassApiService>();
        
        return services;
    }

        
}