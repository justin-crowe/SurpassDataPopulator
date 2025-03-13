using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.Exceptions;

public class TestScheduleCandidateResourceException : ResourceException
{
    public TestScheduleCandidateResourceException(
        string message,
        IEnumerable<ApiHttpError> errors,
        Resource candidate)
        : base(message, errors)
    {
        Candidate = candidate;
    }

    public Resource Candidate { get; }
}