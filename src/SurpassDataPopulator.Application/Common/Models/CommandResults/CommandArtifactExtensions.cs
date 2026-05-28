namespace SurpassDataPopulator.Application.Common.Models.CommandResults;

/// <summary>
/// Extension methods for creating command artifacts with different formats
/// </summary>
public static class CommandArtifactExtensions
{
    /// <summary>
    /// Creates a command artifact in JSON format
    /// </summary>
    public static CommandArtifact AsJson(this object data, string fileName = null, string description = null)
    {
        return new CommandArtifact
        {
            Data = data,
            Format = "json",
            FileName = fileName,
            Description = description
        };
    }

    /// <summary>
    /// Creates a command artifact in XML format
    /// </summary>
    public static CommandArtifact AsXml(this object data, string fileName = null, string description = null)
    {
        return new CommandArtifact
        {
            Data = data,
            Format = "xml",
            FileName = fileName,
            Description = description
        };
    }

    /// <summary>
    /// Creates a command artifact as plain text
    /// </summary>
    public static CommandArtifact AsText(this object data, string fileName = null, string description = null)
    {
        return new CommandArtifact
        {
            Data = data,
            Format = "txt",
            FileName = fileName,
            Description = description
        };
    }

    /// <summary>
    /// Creates a command artifact in CSV format
    /// </summary>
    public static CommandArtifact AsCsv(this object data, string fileName = null, string description = null)
    {
        return new CommandArtifact
        {
            Data = data,
            Format = "csv",
            FileName = fileName,
            Description = description
        };
    }
}
