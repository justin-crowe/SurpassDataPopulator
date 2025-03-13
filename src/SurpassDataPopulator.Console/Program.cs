using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using SurpassDataPopulator.Application;
using SurpassDataPopulator.Infrastructure;

//TODO .net 6 console style
/*
var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((hostingContext, configuration) =>
    {
        configuration.Sources.Clear();
        
        var env = hostingContext.HostingEnvironment;
        
        configuration
            .AddJsonFile("appsettings.json", false, true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);
        
        var configurationRoot = configuration.Build();

        SurpassApiOptions surpassApiOptions = new();
        configurationRoot.GetSection(nameof(SurpassApiOptions)).Bind(surpassApiOptions);
    

    })
    .Build();
*/
namespace SurpassDataPopulator.Console;

static class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            var configuration = BuildConfiguration();
            var serviceProvider = BuildServiceProvider(configuration);
            var app = serviceProvider.GetRequiredService<DataPopulatorApplication>();
            await app.RunAsync(args);
        }
        catch (Exception e)
        {
            Log.Fatal(e, "Error in application");
            throw;
        }
        finally
        {
            Log.Information("Finished..");
            Log.CloseAndFlush();
        }
    }
        
    private static IConfigurationRoot BuildConfiguration()
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false, true)
            //.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", false, true)
            .Build();
            
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateBootstrapLogger();
            
        Log.Information("Starting..");

        return configuration;
    }

    private static ServiceProvider BuildServiceProvider(IConfigurationRoot configuration)
    {
        var services = new ServiceCollection();
        ConfigureServices(services, configuration);
        var serviceProvider = services.BuildServiceProvider();
        return serviceProvider;
    }

    private static void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration)
    {
        services
            .AddSingleton<DataPopulatorApplication>()
            .AddApplication()
            .AddInfrastructure(configuration);
    }
}