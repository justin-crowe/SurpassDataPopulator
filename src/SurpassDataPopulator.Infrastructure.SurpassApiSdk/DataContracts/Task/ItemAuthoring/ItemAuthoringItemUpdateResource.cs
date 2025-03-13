using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.ItemAuthoring;

[DataContract(Name = ApiConsts.Contracts.ItemAuthoringItem, Namespace = "")]
[ControllerName(ApiConsts.Segments.ItemAuthoringTask, 2)]
public class ItemAuthoringItemUpdateResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 1)]
    public long Id { get; set; }

    [DataMember(Name = ApiConsts.Members.State, Order = 2)]
    public ItemAuthoringItemState? State { get; set; }

    [DataMember(Name = ApiConsts.Members.IsFlagged, Order = 3)]
    public bool? IsFlagged { get; set; }
}