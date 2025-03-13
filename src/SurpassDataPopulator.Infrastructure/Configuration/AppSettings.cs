using Microsoft.Extensions.Configuration;

namespace SurpassDataPopulator.Infrastructure.Configuration;

public class AppSettings
{
    /// <summary>
    /// Maps a config section and provides the options class T for immediate usage.
    /// If you're using it in another class via DI, then do not use this, and use the built in Configuration.GetSection methods instead.
    /// </summary>
    /// <param name="configuration"></param>
    /// <param name="configSectionName"></param>
    /// <param name="options"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static IConfigurationSection MapConfigSection<T>(IConfiguration configuration, string configSectionName, out T options) where T : new()
    {
        var configSection = configuration.GetRequiredSection(configSectionName);
        options = new T();
        configSection.Bind(options);
        return configSection;
    }
}