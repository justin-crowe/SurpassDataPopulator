using System.Collections.Generic;

namespace SurpassDataPopulator.Application.Common.Models.CommandResults;

/// <summary>
/// Marker interface for CommandResults that contain artifacts or other items be persisted / displayed
/// by the host layer (e.g., Console app writing to session folder).
/// </summary>
public interface ICommandArtifacts
{
    public List<CommandArtifact> Artifacts { get; set; }

    public List<string> ToDoTasks { get; set; }
}

/// <summary>
/// Container for artifact data that should be persisted after command execution.
/// </summary>
public class CommandArtifact
{
    /// <summary>
    /// The data payload to persist. Can be any serializable object.
    /// </summary>
    public object Data { get; set; }

    /// <summary>
    /// The format of the data (e.g., "json", "xml", "csv", "txt").
    /// Used by the host layer to determine how to serialize and what file extension to use.
    /// </summary>
    public string Format { get; set; } = "json";

    /// <summary>
    /// Optional filename (without extension). If null, a default name will be generated.
    /// </summary>
    public string FileName { get; set; }

    /// <summary>
    /// Optional description of the data for logging purposes.
    /// </summary>
    public string Description { get; set; }
}
