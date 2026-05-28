using SurpassDataPopulator.Domain.Session;
using System.Threading.Tasks;

namespace SurpassDataPopulator.Application.Interfaces.Services;

public interface ISessionManager
{
    SessionInfo CurrentSession { get; }
    string GetOutputPath(string relativePath);
    Task CleanupOldSessionsAsync(int keepCount = 10);
}