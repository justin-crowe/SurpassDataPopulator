using System.Runtime.Serialization;

namespace SurpassApiSdk.Models;

/// <summary>
/// Represents a web api http error
/// </summary>
[DataContract(Name = "Error", Namespace = "")]
public class ApiHttpError
{
    /// <summary>
    /// Creates an instance of <see cref="ApiHttpError"/> with default values
    /// </summary>
    public ApiHttpError()
    {
    }

    /// <summary>
    /// Creates an instance of <see cref="ApiHttpError"/> with provided values
    /// </summary>
    /// <param name="code">Error code</param>
    /// <param name="message">Error message</param>
    public ApiHttpError(int code, string message)
    {
        ErrorCode = code;
        Message = message;
    }

    /// <summary>
    /// Error code
    /// </summary>
    [DataMember(Name = "ErrorCode", Order = 1)]
    public int ErrorCode { get; set; }

    /// <summary>
    /// Error message
    /// </summary>
    [DataMember(Name = "Message", Order = 2)]
    public string Message { get; set; }
}