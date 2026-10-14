using System;
using System.IO;
using System.Reflection;

namespace SurpassDataPopulator.Console;

/// <summary>
/// Provides a stable identifier for this particular tool installation, persisted locally so that
/// log entries (e.g. in Application Insights) can be correlated back to a specific install/machine/user.
/// </summary>
internal static class InstallIdentity
{
    private static readonly string StateDirectory = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "SurpassDataPopulator");

    private static readonly string InstallIdFilePath = Path.Combine(StateDirectory, "install.id");

    public static Guid InstallId { get; } = GetOrCreateInstallId();

    public static string ToolVersion { get; } =
        Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "unknown";

    private static Guid GetOrCreateInstallId()
    {
        try
        {
            Directory.CreateDirectory(StateDirectory);

            if (File.Exists(InstallIdFilePath) &&
                Guid.TryParse(File.ReadAllText(InstallIdFilePath).Trim(), out var existingId))
            {
                return existingId;
            }

            var newId = Guid.NewGuid();
            File.WriteAllText(InstallIdFilePath, newId.ToString());
            return newId;
        }
        catch
        {
            // If we can't persist (e.g. restricted filesystem), fall back to a per-process id
            // rather than failing startup.
            return Guid.NewGuid();
        }
    }
}
