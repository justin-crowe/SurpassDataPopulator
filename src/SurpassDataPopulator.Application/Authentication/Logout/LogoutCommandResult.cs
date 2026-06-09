using System;
using SurpassDataPopulator.Application.Common.Models.CommandResults;

namespace SurpassDataPopulator.Application.Authentication.Logout;

public class LogoutCommandResult : CommandResult<LogoutCommandResult>
{
    public string Username { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;

    public static LogoutCommandResult CreateSuccess(string username = "")
    {
        return CreateSuccess(result =>
        {
            result.Username = username;
            result.Message = "Successfully logged out";
        });
    }

    public static LogoutCommandResult CreateNotLoggedIn(string username)
    {
        var message = username != null ?
            $"Logout failed, no active session found for {username}. Please log in first."
            : "Logout failed, no active session found. Please log in first.";

        return CreateFailure(new Exception(message), result =>
        {
            result.Username = string.Empty;
            result.Message = message;
        });
    }
}
