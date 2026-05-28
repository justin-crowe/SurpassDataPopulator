using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SurpassDataPopulator.Application;
using SurpassDataPopulator.Application.Authentication.Login;
using SurpassDataPopulator.Application.Authentication.Logout;
using SurpassDataPopulator.Application.DataPopulation.Items;
using SurpassDataPopulator.Application.DataPopulation.Items.Adaptive;
using SurpassDataPopulator.Console.Cli;
using SurpassDataPopulator.Console.Cli.Verbs.Authorization.Login;
using SurpassDataPopulator.Console.Cli.Verbs.Authorization.Logout;
using SurpassDataPopulator.Console.Cli.Verbs.Create.Items;
using SurpassDataPopulator.Console.Cli.Verbs.Create.Items.Adaptive;
using SurpassDataPopulator.Console.Display.Mappers;
using SurpassDataPopulator.Infrastructure;
using MediatR;
using SurpassDataPopulator.Console.Behaviours;

namespace SurpassDataPopulator.Console;

public static class DependencyInjection
{
    public static IServiceCollection AddConsoleApplication(this IServiceCollection services, HostBuilderContext builder)
    {
        services.AddSingleton<ProgressAwareMediatrBinder>();

        services.AddApplication();
        services.AddInfrastructure(builder.Configuration);
        
        // Register Console-specific MediatR behaviours
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CliCommandBehaviour<,>));
        
        services.AddConsoleOutput();

        //TODO cant seem to get otel to work in console app with this config
        //services.AddTelemetry(builder.Configuration, builder);

        return services;
    }

    private static void AddConsoleOutput(this IServiceCollection services)
    {
        // Register console output generators for Spectre.Console
        services.AddScoped<IConsoleAppResultOutput<LoginCommandResult>, LoginResultOutput>();
        services.AddScoped<IConsoleAppResultOutput<LogoutCommandResult>, LogoutResultOutput>();
        services.AddScoped<IConsoleAppResultOutput<CreateItemDataResult>, CreateItemsResultOutput>();
        services.AddScoped<IConsoleAppResultOutput<CreateAdaptiveItemsCommandResult>, CreateAdaptiveItemsResultOutput>();
    }
}