using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.Response
{
    /// <summary>
    /// Represents an interface for all response models
    /// </summary>
    public interface IResponse
    {
        IEnumerable<ApiHttpError> Errors { get; set; }
    }
}
