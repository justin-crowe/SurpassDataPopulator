using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using SurpassDataPopulator.Application.Common.Behaviours.Interfaces;
using SurpassDataPopulator.Application.Common.Models.CommandResults;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Domain.Common.Telemetry;

namespace SurpassDataPopulator.Application.Common.Behaviours;

/// <summary>
/// Logs requests, responses and any unhandled exceptions. Tracks requests with OpenTelemetry and includes user information if available.
/// Provides centralized error handling for CommandResult types.
/// </summary>
public class ObservabilityBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull where TResponse : notnull
{
    private readonly ILogger _logger;
    private readonly ICredentialsStore _credentialsStore;

    public ObservabilityBehaviour(ILogger<TRequest> logger, ICredentialsStore credentialsStore)
    {
        _logger = logger;
        _credentialsStore = credentialsStore;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var requestName = typeof(TRequest).Name;
        var credentials = _credentialsStore.Load();

        using var activity = TelemetryConfig.Activity.StartActivity(requestName);
        {
            try
            {
                var username = "anonymous-user";
                if (credentials != null && !string.IsNullOrEmpty(credentials.Username))
                {
                    username = credentials.Username;
                    activity?.SetTag(TelemetryNames.AuthenticatedUserName, credentials.Username);
                }

                if (request is ILoggingBehaviourIgnored)
                {
                    return await next(cancellationToken);
                }

                var requestToLog = new { RequestName = requestName, UserName = username, RequestBody = request };
                _logger.LogInformation("Request: {@Request} ", requestToLog);

                var response = await next(cancellationToken);

                var responseToLog = new { RequestName = requestName, UserName = username, ResponseBody = response };
                _logger.LogInformation("Response: {@Response}", responseToLog);

                return response;
            
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception occurred while performing {RequestName} {@RequestBody}", requestName, request);
                //activity?.AddError(ex);

                // Check if TResponse is a CommandResult type and create a failure result if the main handler hasnt already handled the exception
                var responseType = typeof(TResponse);
                if (IsCommandResult(responseType))
                {
                    var failureResult = CreateFailureResult(responseType, ex);
                    if (failureResult != null)
                    {
                        _logger.LogInformation("Converted exception to failure result for {RequestName}", requestName);
                        return (TResponse)failureResult;
                    }

                    _logger.LogWarning("Unable to convert exception to CommandResult > Failure for {RequestName}", requestName);
                }
                
                // Re-throw if not a CommandResult or couldn't create failure
                throw;
            }
        }
    }
    
    private static bool IsCommandResult(Type type)
    {
        var baseType = type.BaseType;
        while (baseType != null)
        {
            if (baseType.IsGenericType && baseType.GetGenericTypeDefinition() == typeof(CommandResult<>))
            {
                return true;
            }
            baseType = baseType.BaseType;
        }
        return false;
    }

    private static object? CreateFailureResult(Type responseType, Exception exception)
    {
        try
        {
            // Look for a static CreateFailure method with Exception parameter
            var createFailureMethod = responseType.GetMethod(
                "CreateFailure",
                BindingFlags.Public | BindingFlags.Static,
                null,
                new[] { typeof(Exception) },
                null);

            if (createFailureMethod != null)
            {
                return createFailureMethod.Invoke(null, new object[] { exception });
            }

            // Look for CreateFailure with string and Exception parameters
            createFailureMethod = responseType.GetMethod(
                "CreateFailure",
                BindingFlags.Public | BindingFlags.Static,
                null,
                new[] { typeof(string), typeof(Exception) },
                null);

            if (createFailureMethod != null)
            {
                return createFailureMethod.Invoke(null, new object[] { exception.Message, exception });
            }
        }
        catch
        {
            // If reflection fails, return null to let the exception bubble up
            return null;
        }

        return null;
    }
}