using System.Net;

namespace SurpassApiSdk.Exceptions
{
    public class NotFoundException : HttpException
    {
        public NotFoundException(string message)
            : base(HttpStatusCode.NotFound, message)
        {
        }
    }
}
