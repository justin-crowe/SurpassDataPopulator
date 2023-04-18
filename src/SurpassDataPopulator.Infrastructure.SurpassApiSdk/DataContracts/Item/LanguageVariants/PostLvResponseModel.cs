using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.LanguageVariants
{
    /// <summary>
    /// Represents a response for a post request
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
    public class PostLvResponseModel : PostResponseModel
    {
        /// <summary>
        /// Errors found during the request execution
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Language)]
        public LanguageResource Language { get; set; }
    }
}
