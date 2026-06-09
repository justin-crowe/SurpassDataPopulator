using Spectre.Console;
using SurpassDataPopulator.Application.Authentication.Status;
using SurpassDataPopulator.Console.Display.Mappers;

namespace SurpassDataPopulator.Console.Cli.Verbs.Authorization.Status;

public class StatusResultOutput : IConsoleAppResultOutput<StatusCommandResult>
{
    public void Print(StatusCommandResult result)
    {
        if (result.Success)
        {
            AnsiConsole.MarkupLine($"[green]✓[/] {Markup.Escape(result.Message)}");
            AnsiConsole.MarkupLine(
                $"[dim]Connected to: {Markup.Escape(result.Instance)} as {Markup.Escape(result.Username)}[/]");
        }
        else
        {
            var panel = new Panel($"[red]{Markup.Escape(result.Message)}[/]")
            {
                Header = new PanelHeader("[red]No Active Session[/]"),
                Border = BoxBorder.Rounded,
                BorderStyle = new Style(Color.Red)
            };
            if (result.Error != null)
            {
                AnsiConsole.Write(panel);
                AnsiConsole.MarkupLine($"[dim]{Markup.Escape(result.Error.Message)}[/]");
            }
            else
            {
                AnsiConsole.Write(panel);
            }
        }
    }
}
