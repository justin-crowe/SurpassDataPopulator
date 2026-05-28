using System;
using System.Collections.Generic;

namespace SurpassDataPopulator.Application.Common.Models.CommandResults;

public abstract class CommandResult<TResult> where TResult : CommandResult<TResult>, new()
{
    public string Message { get; set; }

    public DateTime TimestampUtc { get; protected set; } = DateTime.UtcNow;

    public bool Success => Error == null;
    
    public Exception? Error { get; protected set; }

    public List<CommandArtifact> Artifacts { get; set; } = [];

    public List<string> ToDoTasks { get; set; } = [];

    /// <summary>
    /// Creates a successful result with custom initialization
    /// </summary>
    protected static TResult CreateSuccess(Action<TResult>? configure = null)
    {
        var result = new TResult
        {
            TimestampUtc = DateTime.UtcNow,
            Error = null
        };
        configure?.Invoke(result);
        return result;
    }

    /// <summary>
    /// Creates a failed result with custom initialization
    /// </summary>
    protected static TResult CreateFailure(Exception error, Action<TResult>? configure = null)
    {
        var result = new TResult
        {
            TimestampUtc = DateTime.UtcNow,
            Error = error
        };
        configure?.Invoke(result);
        return result;
    }

    public void AddArtifact(CommandArtifact artifact)
    {
        Artifacts.Add(artifact);
    }

    public void AddToDoTask(string task)
    {
        ToDoTasks.Add(task);
    }

    public void AddToDoTasks(List<string> tasks)
    {
        ToDoTasks.AddRange(tasks);
    }
}