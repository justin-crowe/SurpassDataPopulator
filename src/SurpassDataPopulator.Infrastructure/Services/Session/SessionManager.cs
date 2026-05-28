using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Domain.Session;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SurpassDataPopulator.Infrastructure.Services.Session;

public class SessionManager : ISessionManager
{
    private readonly SessionInfo _session;
    private readonly string _baseSessionPath;

    public SessionManager()
    {
        var timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
        var uniqueId = Guid.NewGuid().ToString("N")[..6];
        var sessionId = $"{timestamp}_{uniqueId}";

        _baseSessionPath = Path.Combine(Path.GetTempPath(), "SurpassDataPopulator", "sessions");

        var sessionDir = Path.Combine(_baseSessionPath, sessionId);
        Directory.CreateDirectory(sessionDir);

        _session = new SessionInfo
        {
            SessionId = sessionId,
            StartTime = DateTime.Now,
            WorkingDirectory = sessionDir
        };
    }

    public SessionInfo CurrentSession => _session;

    public string GetOutputPath(string relativePath)
    {
        var fullPath = Path.Combine(_session.WorkingDirectory, relativePath);
        var directory = Path.GetDirectoryName(fullPath);
        if (!string.IsNullOrEmpty(directory))
            Directory.CreateDirectory(directory);
        return fullPath;
    }

    public async Task CleanupOldSessionsAsync(int keepCount = 10)
    {
        var sessions = Directory.GetDirectories(_baseSessionPath)
            .OrderByDescending(d => Directory.GetCreationTime(d))
            .Skip(keepCount);

        foreach (var session in sessions)
        {
            await Task.Run(() => Directory.Delete(session, true));
        }
    }
}