using System;
using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using Microsoft.Extensions.DependencyInjection;
using SurpassDataPopulator.Application.Authentication.Login;
using SurpassDataPopulator.Application.Authentication.Logout;
using SurpassDataPopulator.Application.DataPopulation.Items;
using SurpassDataPopulator.Application.DataPopulation.Items.Adaptive;
using SurpassDataPopulator.Console.Cli.Verbs.Authorization.Login;
using SurpassDataPopulator.Console.Cli.Verbs.Authorization.Logout;
using SurpassDataPopulator.Console.Cli.Verbs.Create.Items;
using SurpassDataPopulator.Console.Display.Mappers;
using ConsoleCreateAdaptiveItems = SurpassDataPopulator.Console.Cli.Verbs.Create.Items.Adaptive.CreateAdaptiveItems;

namespace SurpassDataPopulator.Console.Cli;

public class CommandFactory
{
    public static Parser ConfigureCommandLine(IServiceProvider provider)
    {
        var rootCommand = new RootCommand();

        // Add each command to the root command (this will include any subcommands)
        // See https://learn.microsoft.com/en-us/dotnet/standard/commandline/
        
        var progressMediatrService = provider.GetRequiredService<ProgressAwareMediatrBinder>();
        var loginDisplayMapper = provider.GetRequiredService<IConsoleAppResultOutput<LoginCommandResult>>();
        var logoutDisplayMapper = provider.GetRequiredService<IConsoleAppResultOutput<LogoutCommandResult>>();
        var createItemsResultOutput = provider.GetRequiredService<IConsoleAppResultOutput<CreateItemDataResult>>();
        var createAdaptiveItemsResultOutput = provider.GetRequiredService<IConsoleAppResultOutput<CreateAdaptiveItemsCommandResult>>();
        
        rootCommand.AddCommand(new Login(progressMediatrService, loginDisplayMapper));
        rootCommand.AddCommand(new Logout(progressMediatrService, logoutDisplayMapper));
        
        rootCommand.AddCommand(new CreateItems(progressMediatrService, createItemsResultOutput));
        rootCommand.AddCommand(new ConsoleCreateAdaptiveItems(progressMediatrService, createItemsResultOutput, createAdaptiveItemsResultOutput));

        var commandlineBuilder = new CommandLineBuilder(rootCommand);
        return commandlineBuilder.UseDefaults().Build();
    }
}