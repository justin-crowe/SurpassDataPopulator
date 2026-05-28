using System;

namespace SurpassDataPopulator.Domain.Session;

public class SessionInfo
{
    public string SessionId { get; init; }
    public DateTime StartTime { get; init; }
    public string WorkingDirectory { get; set; }
}