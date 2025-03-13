using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class ItemResponseTbsMo
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 1, EmitDefaultValue = true)]
    public string Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Correct, Order = 2, EmitDefaultValue = true)]
    public bool Correct { get; set; }

    [DataMember(Name = ApiConsts.Members.WeightedMark, Order = 3, EmitDefaultValue = true)]
    public int WeightedMark { get; set; }
}