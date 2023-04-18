using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using SurpassDataPopulator.Infrastructure.Services.OpenTriviaApi;
using SurpassDataPopulator.Infrastructure.Services.Surpass;

namespace SurpassDataPopulator.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddOpenTriviaApi(configuration)
                .AddSurpassApi(configuration)
                
                .AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));
            
            return services;
        }
    }
}