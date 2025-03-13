using SurpassApiSdk.Models;

namespace SurpassApiSdk.Exceptions;

public class ResourceException : Exception
{
    public ResourceException(string message, IEnumerable<ApiHttpError> errors)
        : base(message)
    {
        Errors = errors;
    }

    public IEnumerable<ApiHttpError> Errors { get; }
}