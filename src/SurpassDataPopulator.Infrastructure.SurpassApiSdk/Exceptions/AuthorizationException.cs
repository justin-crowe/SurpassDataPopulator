using System.Net;

namespace SurpassApiSdk.Exceptions;

public class AuthorizationException : HttpException
{
    public AuthorizationException(string message)
        : base(HttpStatusCode.Unauthorized, message)
    {
    }
}