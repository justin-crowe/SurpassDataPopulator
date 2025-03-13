using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class AnswerRange
{
    [DataMember(Name = ApiConsts.Members.MinValue, EmitDefaultValue = false)]
    public decimal Min { get; set; }

    [DataMember(Name = ApiConsts.Members.MaxValue, EmitDefaultValue = false)]
    public decimal Max { get; set; }
}