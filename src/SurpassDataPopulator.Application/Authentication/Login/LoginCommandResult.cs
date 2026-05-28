using System;
using SurpassDataPopulator.Application.Common.Models.CommandResults;

namespace SurpassDataPopulator.Application.Authentication.Login;

public class LoginCommandResult : CommandResult<LoginCommandResult>
{
    public string Username { get; set; } = string.Empty;

    public string Host { get; set; } = string.Empty;

    public bool IsAuthenticated { get; set; }

    public string ConnectionUrl { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;

    public static LoginCommandResult CreateSuccess(string username, string host, string connectionUrl)
    {
        return CreateSuccess(result =>
        {
            result.Username = username;
            result.Host = host;
            result.ConnectionUrl = connectionUrl;
            result.IsAuthenticated = true;
            result.Message = $"Successfully logged in as {username} @ {host}";
        });
    }

    public static LoginCommandResult CreateFailure(string username, string host, string message, Exception? error = null)
    {
        return CreateFailure(error ?? new Exception(message), result =>
        {
            result.Username = username;
            result.Host = host;
            result.ConnectionUrl = string.Empty;
            result.IsAuthenticated = false;
            result.Message = message;
        });
    }
}