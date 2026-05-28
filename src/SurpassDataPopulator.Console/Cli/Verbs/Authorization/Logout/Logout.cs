using System.CommandLine;
using MediatR;
using SurpassDataPopulator.Application.Authentication.Logout;
using SurpassDataPopulator.Console.Display.Mappers;

namespace SurpassDataPopulator.Console.Cli.Verbs.Authorization.Logout;

public class Logout : Command
{
    public Logout(ProgressAwareMediatrBinder mediatorBinder, IConsoleAppResultOutput<LogoutCommandResult> consoleAppResultOutput) 
        : base("logout", "Logs out of the instance you are logged into")
    {
        this.SetHandler(
            async (ProgressAwareSender sender) =>
            {
                var result = await sender.SendWithProgressAsync<LogoutCommandResult>(
                    new LogoutCommand(),
                    "Logging out...");
                consoleAppResultOutput.Print(result);
            },
            mediatorBinder);
    }
}