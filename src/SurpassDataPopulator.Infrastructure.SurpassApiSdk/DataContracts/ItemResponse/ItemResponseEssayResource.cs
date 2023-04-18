using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class ItemResponseEssayResource : ItemResponseBaseResource
    {
        [DataMember(Name = ApiConsts.Members.CandidateResponse, EmitDefaultValue = false, Order = 9)]
        public ItemResponseEssay Response { get; set; }
    }
}
