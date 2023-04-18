using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class ItemResponseShortAnswerOption : BaseCandidateItemResponseResource<string>
    {
        [DataMember(Name = ApiConsts.Members.Answers, EmitDefaultValue = false, Order = 2)]
        public List<string> AnswerList { get; set; }
    }
}
