using System;
using Meziantou.Framework.Win32;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Infrastructure.Services.Surpass;

namespace SurpassDataPopulator.Infrastructure.Services.Credentials;

public class CredentialsStore : ICredentialsStore
{
    private readonly SurpassApiOptions _configOptions;
    private readonly ILogger<CredentialsStore> _logger;
    private Domain.Authentication.Credentials _newlyStagedCredentials;

    private const string CredentialName = "SurpassDataPopulatorConsole";

    public CredentialsStore(IOptions<SurpassApiOptions> configOptions, ILogger<CredentialsStore> logger)
    {
        _logger = logger;
        _configOptions = configOptions.Value;
    }
    
    public void StageNewCredentials(Domain.Authentication.Credentials credentials)
    {
        _newlyStagedCredentials = credentials;
    }

    public void Save(Domain.Authentication.Credentials credentials)
    {
        // Combine URL and password for storage, or use custom fields if you want to serialize as JSON
        var secret = $"{credentials.Url}|{credentials.Password}";
        CredentialManager.WriteCredential(
            applicationName: CredentialName,
            userName: credentials.Username,
            secret: secret,
            persistence: CredentialPersistence.LocalMachine
        );
    }

    public Domain.Authentication.Credentials? Load()
    {
        if (_newlyStagedCredentials != null) return _newlyStagedCredentials;

        var credentials = CredentialManager.ReadCredential(CredentialName);
        if (credentials == null)
        {
            _logger.LogDebug("Credentials not found in Credential Manager. Using default configuration from app settings.");

            if (string.IsNullOrEmpty(_configOptions.BaseUrl) && string.IsNullOrEmpty(_configOptions.Password) && string.IsNullOrEmpty(_configOptions.Password))
            {
                _logger.LogDebug("Credentials were not found in the appsettings.");
                return null;
            }

            _logger.LogDebug($"Credentials for {_configOptions.BaseUrl}-{_configOptions.Username} found in appsettings - using those for the connection.");
            return new Domain.Authentication.Credentials
            {
                Url = _configOptions.BaseUrl,
                Username = _configOptions.Username,
                Password = _configOptions.Password
            };
        }

        var parts = credentials.Password.Split('|', 2);
        if (parts.Length != 2) return null;
        
        var url = parts[0];
        _logger.LogDebug($"Credentials for {url}-{credentials.UserName} found in store - using those for the connection.");

        return new Domain.Authentication.Credentials
        {
            Url = url,
            Username = credentials.UserName,
            Password = parts[1]
        };
    }

    public void Delete()
    {
        CredentialManager.DeleteCredential(CredentialName);
    }
}