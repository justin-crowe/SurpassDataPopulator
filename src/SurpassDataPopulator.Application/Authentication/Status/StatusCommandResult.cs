using SurpassDataPopulator.Application.Common.Models.CommandResults;
using System;

namespace SurpassDataPopulator.Application.Authentication.Status;

public class StatusCommandResult : CommandResult<StatusCommandResult>
{
    public string Instance;
    public string Username;

    public static StatusCommandResult CreateSuccess(string username, string instance)
    {
        return CreateSuccess(result =>
        {
            result.Username = username;
            result.Instance = instance;
            result.Message = "Logged in";
        });
    }

    public static StatusCommandResult CreateNoCredentials()
    {
        var message = "No active session found. Please log in first.";
        return CreateFailure(new Exception(message), result =>
        {
            result.Username = string.Empty;
            result.Instance = string.Empty;
            result.Message = message;
        });
    }
}
