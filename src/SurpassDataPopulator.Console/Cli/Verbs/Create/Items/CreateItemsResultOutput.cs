using System.Linq;
using Spectre.Console;
using SurpassDataPopulator.Console.Display.Mappers;
using SurpassDataPopulator.Application.DataPopulation.Items;

namespace SurpassDataPopulator.Console.Cli.Verbs.Create.Items;

public class CreateItemsResultOutput : IConsoleAppResultOutput<CreateItemDataResult>
{
    public void Print(CreateItemDataResult result)
    {
        AnsiConsole.WriteLine();

        if (result.Success)
        {
            DisplaySuccess(result);
        }
        else
        {
            DisplayFailure(result);
        }

        AnsiConsole.WriteLine();
    }

    private static void DisplaySuccess(CreateItemDataResult result)
    {
        var headerText = $"[green]✓[/] Created [bold]{result.TotalItemsCreated}[/] items in [blue]{result.ProcessingTime.TotalSeconds:F2}s[/]";
        AnsiConsole.MarkupLine(headerText);

        AnsiConsole.MarkupLine($"[dim]Subject: {result.SubjectReference}[/]");

        if (result.ItemsByCategory.Any())
        {
            AnsiConsole.WriteLine();
            
            var table = new Table()
                .AddColumn("[bold]Category[/]")
                .AddColumn("[bold]Items Created[/]", column => column.Alignment(Justify.Right))
                .Border(TableBorder.Rounded)
                .BorderColor(Color.Blue);

            foreach (var category in result.ItemsByCategory)
            {
                table.AddRow(
                    $"[yellow]{category.Key}[/]", 
                    $"[green]{category.Value}[/]"
                );
            }

            AnsiConsole.Write(table);
        }

        if (result.HasMedia)
        {
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("[dim]Features: [cyan]Media attached[/][/]", result);
        }

        if (result.Items.Any())
        {
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("[bold]Sample Items:[/]");
            
            foreach (var item in result.Items.Take(5))
            {
                var mediaIcon = item.HasMedia ? "📎 " : "";
                AnsiConsole.MarkupLine($"  • [dim]{item.Category}[/] {mediaIcon}{item.Title.EscapeMarkup()}");
            }

            if (result.Items.Count > 5)
            {
                AnsiConsole.MarkupLine($"  [dim]... and {result.Items.Count - 5} more[/]");
            }
        }
    }

    private static void DisplayFailure(CreateItemDataResult result)
    {
        var panel = new Panel(
            new Markup($"[red]✗[/] {result.Message.EscapeMarkup()}")
        )
        {
            Border = BoxBorder.Rounded,
            BorderStyle = new Style(Color.Red),
            Header = new PanelHeader("[red]Failed to Create Items[/]")
        };

        AnsiConsole.Write(panel);

        if (result.Error != null)
        {
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine($"[dim]Error: {result.Error.Message.EscapeMarkup()}[/]");
        }
    }
}