using SurpassDataPopulator.Console.Display.Mappers;
using Spectre.Console;
using SurpassDataPopulator.Application.Authentication.Login;

namespace SurpassDataPopulator.Console.Cli.Verbs.Authorization.Login;

public class LoginResultOutput : IConsoleAppResultOutput<LoginCommandResult>
{
    public void Print(LoginCommandResult result)
    {
        if (result.Success && result.IsAuthenticated)
        {
            AnsiConsole.MarkupLine($"[green]✓[/] {Markup.Escape(result.Message)}");
            AnsiConsole.MarkupLine($"[dim]Connected to: {Markup.Escape(result.ConnectionUrl)}[/]");
        }
        else
        {
            var panel = new Panel($"[red]{Markup.Escape(result.Message)}[/]")
            {
                Header = new PanelHeader("[red]Authentication Failed[/]"),
                Border = BoxBorder.Rounded,
                BorderStyle = new Style(Color.Red)
            };

            if (result.Error != null)
            {
                AnsiConsole.Write(panel);
                AnsiConsole.MarkupLine($"[dim]Exception.Message: {Markup.Escape(result.Error.Message)}[/]");
            }
            else
            {
                AnsiConsole.Write(panel);
            }

            if (!string.IsNullOrEmpty(result.Username))
            {
                AnsiConsole.MarkupLine($"[dim]Username: {Markup.Escape(result.Username)}[/]");
            }
            if (!string.IsNullOrEmpty(result.Host))
            {
                AnsiConsole.MarkupLine($"[dim]Host: {Markup.Escape(result.Host)}[/]");
            }
        }
    }
}