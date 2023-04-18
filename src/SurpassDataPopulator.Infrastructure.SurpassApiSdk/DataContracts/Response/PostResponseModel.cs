using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.Response
{
    /// <summary>
    /// Represents a response for a post request
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
    public class PostResponseModel : LinkedResource, IResponse
    {
        /// <summary>
        /// Errors found during the request execution
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Errors, Order = 4)]
        public IEnumerable<ApiHttpError> Errors { get; set; }
    }
}
