using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class BaseCandidateItemResponseResource<T>
    {
        [DataMember(Name = ApiConsts.Members.Response, EmitDefaultValue = true, Order = 1)]
        public T UserAnswer { get; set; }
    }
}
