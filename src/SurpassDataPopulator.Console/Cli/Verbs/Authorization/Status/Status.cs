using SurpassDataPopulator.Console.Display.Mappers;
using System.CommandLine;
using SurpassDataPopulator.Application.Authentication.Status;

namespace SurpassDataPopulator.Console.Cli.Verbs.Authorization.Status
{
    public class Status : Command
    {
        public Status(ProgressAwareMediatrBinder mediatorBinder, IConsoleAppResultOutput<StatusCommandResult> consoleAppResultOutput)
            : base("status", "retrieves current credentials and lets the user know which instance they are currently logged into")
        {
            this.SetHandler(
                async (ProgressAwareSender sender) =>
                {
                    var result = await sender.SendWithProgressAsync<StatusCommandResult>(
                        new StatusCommand(),
                        "Checking credentials");
                    consoleAppResultOutput.Print(result);
                },
                mediatorBinder);
        }
    }
}
