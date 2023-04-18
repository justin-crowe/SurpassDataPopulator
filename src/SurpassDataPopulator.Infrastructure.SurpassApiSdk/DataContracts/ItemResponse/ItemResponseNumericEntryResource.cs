using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class ItemResponseNumericEntryResource : ItemResponseBaseResource
    {
        [DataMember(Name = ApiConsts.Members.CandidateResponse, Order = 6, EmitDefaultValue = false)]
        public List<NumericalEntryOptions> OptionList { get; set; }
    }
}
