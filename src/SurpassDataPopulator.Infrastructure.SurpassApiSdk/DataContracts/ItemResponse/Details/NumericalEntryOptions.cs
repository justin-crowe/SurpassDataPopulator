using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class NumericalEntryOptions : BaseCandidateItemResponseResource<decimal>
{
    [DataMember(Name = ApiConsts.Members.Answers, EmitDefaultValue = false, Order = 2)]
    public List<decimal> Answers { get; set; }

    [DataMember(Name = ApiConsts.Members.AnswerRange, EmitDefaultValue = false, Order = 2)]
    public AnswerRange AnswerRange { get; set; }
}