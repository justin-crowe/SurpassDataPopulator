using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ItemTagValue;

[DataContract(Name = ApiConsts.Contracts.ItemTagValue, Namespace = "")]
[ControllerName(ApiConsts.Segments.ItemTagValue, 2)]
public class SubjectTagValueItemResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.TagValue, EmitDefaultValue = false, Order = 3)]
    public LinkedResource TagValue { get; set; }

    [DataMember(Name = ApiConsts.Members.Item, EmitDefaultValue = false, Order = 4)]
    public LinkedResource Item { get; set; }

    [DataMember(Name = ApiConsts.Members.Mark, EmitDefaultValue = false, Order = 5)]
    public int? Mark { get; set; }

    [DataMember(Name = ApiConsts.Members.Collection, Order = 5, EmitDefaultValue = false)]
    public TagCollection.TagCollectionRootLinkedResource Collection { get; set; }
}