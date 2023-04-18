using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class ItemResponseHotSpotResource : ItemResponseBaseResource
    {
        [DataMember(Name = ApiConsts.Members.AreaType, EmitDefaultValue = false, Order = 7)]
        public string AreaType { get; set; }

        [DataMember(Name = ApiConsts.Members.CandidateResponse, EmitDefaultValue = false, Order = 8)]
        public ItemResponseHotSpotOption OptionList { get; set; }
    }
}
