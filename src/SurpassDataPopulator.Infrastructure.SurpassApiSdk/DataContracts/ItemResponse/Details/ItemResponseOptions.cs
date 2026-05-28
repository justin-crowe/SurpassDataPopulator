using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class ItemResponseOptions : BaseOptionModelResource
{
    [DataMember(Name = ApiConsts.Members.WeightedMark, Order = 6, EmitDefaultValue = true)]
    public int? WeightedMark { get; set; }

    [DataMember(Name = ApiConsts.Members.RequiresExtraInfo, Order = 7, EmitDefaultValue = false)]
    public bool? RequiresExtraInfo { get; set; }

    [DataMember(Name = ApiConsts.Members.ExtraInfo, Order = 8)]
    public string ExtraInfo { get; set; }

    [DataMember(Name = ApiConsts.Members.ExtraInfoLabel, Order = 9)]
    public string ExtraInfoLabel { get; set; }
}