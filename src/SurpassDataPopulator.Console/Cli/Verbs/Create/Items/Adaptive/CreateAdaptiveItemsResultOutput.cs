using Spectre.Console;
using SurpassDataPopulator.Application.DataPopulation.Items.Adaptive;
using SurpassDataPopulator.Console.Display.Mappers;
using System.Collections.Generic;
using System.Linq;

namespace SurpassDataPopulator.Console.Cli.Verbs.Create.Items.Adaptive;

public class CreateAdaptiveItemsResultOutput : IConsoleAppResultOutput<CreateAdaptiveItemsCommandResult>
{
    public void Print(CreateAdaptiveItemsCommandResult commandResult)
    {
        AnsiConsole.WriteLine();

        if (commandResult.Success)
        {
            DisplaySuccess(commandResult);
        }
        else
        {
            DisplayFailure(commandResult);
        }

        AnsiConsole.WriteLine();
    }

    private static void DisplaySuccess(CreateAdaptiveItemsCommandResult commandResult)
    {
        // Success header
        var typeText = commandResult.IsAdaptive ? "adaptive items" : "items";
        var headerText = $"[green]✓[/] Created [bold]{commandResult.TotalItemsCreated}[/] {typeText} in Subject: {commandResult.SubjectReference}";
        AnsiConsole.MarkupLine(headerText);

        // Additional features
        var features = new List<string>();
        if (commandResult.HasMedia) features.Add("[cyan]Media attached[/]");
        if (commandResult.IsAdaptive) features.Add("[magenta]Adaptive specific tags[/]");
        if (commandResult.LanguageVariants.Any()) 
        {
            var variants = string.Join(", ", commandResult.LanguageVariants);
            features.Add($"[yellow]Language variants: {variants}[/]");
        }

        if (features.Any())
        {
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine($"[dim]Item Features: {string.Join(", ", features)}[/]");
        }

        // Sample items
        if (commandResult.Items.Any())
        {
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("[bold]Sample Items:[/]");
            
            foreach (var item in commandResult.Items.Take(5))
            {
                var mediaIcon = item.HasMedia ? "📎 " : "";
                var variantText = !string.IsNullOrEmpty(item.LanguageVariant) ? $" [{item.LanguageVariant}]" : "";
                AnsiConsole.MarkupLine($"  • [dim]{item.Category}[/] {mediaIcon}{item.Title.EscapeMarkup()}{variantText}");
            }

            if (commandResult.Items.Count > 5)
            {
                AnsiConsole.MarkupLine($"  [dim]... and {commandResult.Items.Count - 5} more[/]");
            }
        }
    }

    private static void DisplayFailure(CreateAdaptiveItemsCommandResult commandResult)
    {
        var panel = new Panel(
            new Markup($"[red]✗[/] {commandResult.Message}")
        )
        {
            Border = BoxBorder.Rounded,
            BorderStyle = new Style(Color.Red),
            Header = new PanelHeader(" Item Creation Failed "),
            Padding = new Padding(1, 0, 1, 0)
        };

        AnsiConsole.Write(panel);

        if (commandResult.Error != null)
        {
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine($"[dim]Details: {commandResult.Error.Message}[/]");
        }
    }
}