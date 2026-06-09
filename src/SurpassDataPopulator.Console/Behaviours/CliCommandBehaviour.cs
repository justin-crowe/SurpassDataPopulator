using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MediatR;
using Microsoft.Extensions.Logging;
using Spectre.Console;
using SurpassDataPopulator.Application.Common.Models.CommandResults;
using SurpassDataPopulator.Application.Interfaces.Services;

namespace SurpassDataPopulator.Console.Behaviours;

public class CliCommandBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
    where TResponse : notnull
{
    private readonly ISessionManager _sessionManager;
    private readonly ILogger<CliCommandBehaviour<TRequest, TResponse>> _logger;

    public CliCommandBehaviour(ISessionManager sessionManager, ILogger<CliCommandBehaviour<TRequest, TResponse>> logger)
    {
        _sessionManager = sessionManager;
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var response = await next(cancellationToken);

        if (response is not ICommandArtifacts responseWithArtifacts || !IsSuccessfulResponse(response))
            return response;

        try
        {
            // Check and render todos FIRST
            var todos = responseWithArtifacts.ToDoTasks;
            if (todos != null)
            {
                await RenderAndPersistTodosAsync(todos, cancellationToken);
            }

            // Then check and render artifacts
            if (response is ICommandArtifacts artifactsResponse && artifactsResponse.Artifacts != null && artifactsResponse.Artifacts.Count > 0)
            {
                await PersistArtifactsAsync(artifactsResponse.Artifacts, cancellationToken);
            }

            // Open session folder if any output was created
            if ((todos?.Count > 0) || (responseWithArtifacts.Artifacts?.Count > 0))
            {
                OpenSessionFolder();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to persist command artifacts for {RequestName}", typeof(TRequest).Name);
        }

        return response;
    }

    private async Task PersistArtifactsAsync(List<CommandArtifact> artifacts, CancellationToken cancellationToken)
    {
        var table = new Table()
            .Border(TableBorder.Rounded)
            .BorderColor(Color.Grey)
            .AddColumn(new TableColumn("[bold]Description[/]").LeftAligned())
            .AddColumn(new TableColumn("[bold]File Name[/]").LeftAligned())
            .AddColumn(new TableColumn("[bold]Type[/]").Centered())
            .AddColumn(new TableColumn("[bold]Path[/]").LeftAligned());

        foreach (var artifact in artifacts)
        {
            var fileName = artifact.FileName ?? $"output_{DateTime.Now:yyyyMMdd_HHmmss}";
            var fileExtension = GetFileExtension(artifact.Format);
            var filePath = _sessionManager.GetOutputPath($"{fileName}.{fileExtension}");

            var serializedData = SerializeData(artifact.Data, artifact.Format);

            await File.WriteAllTextAsync(filePath, serializedData, cancellationToken);

            _logger.LogInformation(
                "Artifact data written to: {FilePath} ({Format} format)",
                filePath,
                artifact.Format);

            // Add row to table
            var fullFileName = $"{fileName}.{fileExtension}";
            var formatDisplay = GetFormatDisplay(artifact.Format);
            var description = artifact.Description ?? "[dim]No description[/]";
            var pathDisplay = $"[dim]{filePath}[/]";

            table.AddRow(
                description,
                $"[cyan]{fullFileName}[/]",
                formatDisplay,
                pathDisplay);
        }

        var sessionFolder = _sessionManager.CurrentSession.WorkingDirectory;

        var panel = new Panel(table)
        {
            Header = new PanelHeader("[yellow]Artifacts Created[/]"),
            Border = BoxBorder.Rounded,
            BorderStyle = new Style(Color.Tan)
        };

        AnsiConsole.Write(panel);
        AnsiConsole.MarkupLine($"[dim]Session folder: {sessionFolder}[/]");
    }

    private async Task RenderAndPersistTodosAsync(List<string> todos, CancellationToken cancellationToken)
    {
        // Create numbered list for display
        var numberedTodos = todos.Select((t, i) => $"{i + 1}. {t}").ToList();

        // Create panel with todos
        var todoList = string.Join("\n", numberedTodos);
        var panel = new Panel(new Markup(todoList))
        {
            Header = new PanelHeader("[yellow]To-Do Tasks - Need to be done manually[/]"),
            Border = BoxBorder.Rounded,
            BorderStyle = new Style(Color.Yellow)
        };

        // Render to console
        AnsiConsole.Write(panel);

        // Persist to file
        var todoFilePath = _sessionManager.GetOutputPath("todos.txt");
        var todoContent = string.Join(Environment.NewLine, numberedTodos);
        await File.WriteAllTextAsync(todoFilePath, todoContent, cancellationToken);

        _logger.LogInformation("Todo tasks written to: {FilePath}", todoFilePath);
    }

    private static string SerializeData(object data, string format)
    {
        return format.ToLowerInvariant() switch
        {
            "json" => JsonSerializer.Serialize(data, new JsonSerializerOptions 
            { 
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            }),

            "xml" => SerializeToXml(data),

            "txt" or "text" => data?.ToString() ?? string.Empty,

            _ => JsonSerializer.Serialize(data, new JsonSerializerOptions 
            { 
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            })
        };
    }

    private static string SerializeToXml(object data)
    {
        var serializer = new XmlSerializer(data.GetType());
        using var stringWriter = new StringWriter();
        serializer.Serialize(stringWriter, data);
        return stringWriter.ToString();
    }

    private static string GetFileExtension(string format)
    {
        return format.ToLowerInvariant() switch
        {
            "json" => "json",
            "xml" => "xml",
            "txt" or "text" => "txt",
            "csv" => "csv",
            _ => "json"
        };
    }

    private static string GetFormatDisplay(string format)
    {
        return format.ToLowerInvariant() switch
        {
            "json" => "[green]JSON[/]",
            "xml" => "[blue]XML[/]",
            "txt" or "text" => "[white]TXT[/]",
            "csv" => "[yellow]CSV[/]",
            _ => $"[grey]{format.ToUpperInvariant()}[/]"
        };
    }

    private static bool IsSuccessfulResponse(TResponse response)
    {
        // Check if response has a Success property
        var successProperty = response.GetType().GetProperty("Success");
        if (successProperty != null && successProperty.PropertyType == typeof(bool))
        {
            return (bool)(successProperty.GetValue(response) ?? false);
        }

        // For responses without Success property, assume success if no exception was thrown
        return true;
    }

    private void OpenSessionFolder()
    {
        try
        {
            var sessionFolder = _sessionManager.CurrentSession.WorkingDirectory;

            if (OperatingSystem.IsWindows())
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "explorer.exe",
                    Arguments = sessionFolder,
                    UseShellExecute = true
                });
            }
            else if (OperatingSystem.IsMacOS())
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "open",
                    Arguments = sessionFolder,
                    UseShellExecute = true
                });
            }
            else if (OperatingSystem.IsLinux())
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "xdg-open",
                    Arguments = sessionFolder,
                    UseShellExecute = true
                });
            }

            _logger.LogDebug("Opened session folder: {SessionFolder}", sessionFolder);
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Failed to open session folder");
        }
    }
}
