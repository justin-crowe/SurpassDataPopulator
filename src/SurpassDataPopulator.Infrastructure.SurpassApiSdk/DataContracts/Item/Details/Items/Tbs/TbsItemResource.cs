using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details.Items.Tbs;

[CollectionSize(1)]
[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class TbsItemResource
{
    [DataMember(Name = ApiConsts.Members.Tbs.ItemContent)]
    public string ItemContent { get; set; }

    [DataMember(Name = ApiConsts.Members.Tbs.RubricXml)]
    public string RubricXml { get; set; }

    [DataMember(Name = ApiConsts.Members.Tbs.MoList, EmitDefaultValue = false)]
    public List<TbsMeasurementOpportunityResource> MoList { get; set; }
}