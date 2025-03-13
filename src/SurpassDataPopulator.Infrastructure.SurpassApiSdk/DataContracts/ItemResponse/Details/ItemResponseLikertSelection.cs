using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details;

[DataContract(Name = ApiConsts.Contracts.LikertSelection, Namespace = "")]
public class ItemResponseLikertSelection
{
    [DataMember(Name = ApiConsts.Members.OptionId, Order = 1, EmitDefaultValue = false)]
    public int OptionId { get; set; }

    [DataMember(Name = ApiConsts.Members.StatementId, Order = 1, EmitDefaultValue = false)]
    public int StatementId { get; set; }
}