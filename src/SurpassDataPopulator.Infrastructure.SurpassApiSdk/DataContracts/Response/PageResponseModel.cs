using System.Collections;
using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Response;

/// <summary>
/// Represents an expanded <see cref="PageResponse{T}"/>
/// </summary>
/// <typeparam name="T">Response resource type</typeparam>
[DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
public class PageResponseModel<T> : PageResponse<T>, IEnumerable<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PageResponseModel{T}"/> class.
    /// </summary>
    public PageResponseModel()
    {
        Response = Array.Empty<T>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PageResponseModel{T}"/> class.
    /// </summary>
    /// <param name="result">Single result for a response</param>
    public PageResponseModel(T result)
    {
        Response = new[] { result };
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PageResponseModel{T}"/> class.
    /// </summary>
    /// <param name="results">Results for a response</param>
    public PageResponseModel(IEnumerable<T> results)
    {
        Response = results;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PageResponseModel{T}"/> class.
    /// Used when server driven paging is enabled
    /// </summary>
    /// <param name="items">response elements list</param>
    /// <param name="count">amount of elements</param>
    public PageResponseModel(IEnumerable<T> items, long? count)
        : base(items, count)
    {
    }

    public IEnumerator<T> GetEnumerator()
    {
        return Response.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}