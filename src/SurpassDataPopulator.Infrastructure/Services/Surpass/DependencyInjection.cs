using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Infrastructure.Configuration;
using SurpassDataPopulator.Infrastructure.Http;
using SurpassDataPopulator.Infrastructure.Services.Surpass.Api.V2;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass
{
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
            
            services
                .AddTransient<HttpLoggingHandler>()
                .Configure<SurpassApiOptions>(configSection)
                .AddRefitClient<ISurpassV2Api>(refitSettings)
                .ConfigureHttpClient(x =>
                    { 
                        x.BaseAddress = new Uri(options.BaseUrl); 
                        x.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                            Convert.ToBase64String(Encoding.ASCII.GetBytes($"{options.Username}:{options.Password}")));
                    })
                #if DEBUG
                    .AddHttpMessageHandler<HttpLoggingHandler>()
                #endif
                ;
            
            services
                .AddTransient<ISurpassApiService, SurpassApiService>();
            
            return services;
        }

        
    }
}