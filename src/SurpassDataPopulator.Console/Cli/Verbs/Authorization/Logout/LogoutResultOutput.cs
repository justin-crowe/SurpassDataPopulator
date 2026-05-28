using SurpassDataPopulator.Console.Display.Mappers;
using Spectre.Console;
using SurpassDataPopulator.Application.Authentication.Logout;

namespace SurpassDataPopulator.Console.Cli.Verbs.Authorization.Logout;

public class LogoutResultOutput : IConsoleAppResultOutput<LogoutCommandResult>
{
    public void Print(LogoutCommandResult result)
    {
        if (result.Success)
        {
            // Success case - green checkmark and message
            AnsiConsole.MarkupLine($"[green]✓[/] {Markup.Escape(result.Message)}");
            
            if (!string.IsNullOrEmpty(result.Username))
            {
                AnsiConsole.MarkupLine($"[dim]User: {Markup.Escape(result.Username)}[/]");
            }
        }
        else
        {
            // Failure case (unlikely for logout but handling it)
            AnsiConsole.MarkupLine($"[red]✗[/] {Markup.Escape(result.Message)}");
            
            if (result.Error != null)
            {
                AnsiConsole.MarkupLine($"[dim]Error: {Markup.Escape(result.Error.Message)}[/]");
            }
        }
    }
}