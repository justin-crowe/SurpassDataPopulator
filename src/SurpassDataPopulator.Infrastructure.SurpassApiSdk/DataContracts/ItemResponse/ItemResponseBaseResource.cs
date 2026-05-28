using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class ItemResponseBaseResource
{
    [DataMember(Name = ApiConsts.Members.AwardedMark, Order = 1, EmitDefaultValue = true)]
    public decimal AwardedMark { get; set; }

    [DataMember(Name = ApiConsts.Members.Id, Order = 2, EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Weighting, Order = 3, EmitDefaultValue = false)]
    public decimal Weighting { get; set; }

    [DataMember(Name = ApiConsts.Members.Attempted, Order = 4, EmitDefaultValue = true)]
    public bool Attempted { get; set; }

    [DataMember(Name = ApiConsts.Members.UserMark, EmitDefaultValue = false)]
    public decimal UserMark { get; set; }

    [DataMember(Name = ApiConsts.Members.Type, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ResultItemType Type { get; set; }
}