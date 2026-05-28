using System;
using System.CommandLine.Parsing;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Spectre.Console;
using SurpassDataPopulator.Console;
using SurpassDataPopulator.Console.Cli;

var host = new HostBuilder()
    .UseContentRoot(Directory.GetCurrentDirectory())
    .ConfigureAppConfiguration((hostingContext, config) =>
    {
        config.SetBasePath(Directory.GetCurrentDirectory());
        config.AddEnvironmentVariables();
        config.AddJsonFile("appsettings.json", true);
#if DEBUG
        config.AddJsonFile("appsettings.Development.json", true);
#endif
    })
    .ConfigureServices((hostingContext, services) =>
    {
        services.AddConsoleApplication(hostingContext);
    })
    .ConfigureLogging((hostingContext, logging) =>
    {
        var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(hostingContext.Configuration)
            .Enrich.FromLogContext()
            .CreateLogger();
        Log.Logger = logger;
        logging.AddSerilog(logger);
    })
    .Build();

Log.Logger.Verbose("Starting with args {Args}", string.Join(',', args));

try
{
    var parser = CommandFactory.ConfigureCommandLine(host.Services);
    var result = await parser.InvokeAsync(args);
    return 0;
}
catch (Exception ex)
{
    Print("An unhandled exception occurred. See logs for details.");
    AnsiConsole.WriteException(ex);
    Log.Logger.Error(ex, "Unhandled exception");
    return 1;
}
finally
{
    Print("Finished");
    Print("Press any key to exit...");
    Log.CloseAndFlush();
    Console.ReadKey(); // Wait for user input before closing
}

void Print(string message)
{
    AnsiConsole.WriteLine(message);
    Log.Logger.Information(message);
}