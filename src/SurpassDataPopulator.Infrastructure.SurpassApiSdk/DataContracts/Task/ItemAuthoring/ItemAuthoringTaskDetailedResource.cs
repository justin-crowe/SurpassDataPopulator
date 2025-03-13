using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.ItemAuthoring;

[DataContract(Name = ApiConsts.Contracts.ItemAuthoringTask, Namespace = "")]
[ControllerName(ApiConsts.Segments.ItemAuthoringTask, 2)]
public class ItemAuthoringTaskDetailedResource : ItemTaskWithStatusAndHistoryDetailedResource
{
    [DataMember(Name = ApiConsts.Members.TaskProfile, Order = 12)]
    public TaskProfileResource TaskProfile { get; set; }

    [DataMember(Name = ApiConsts.Members.IsChangesTrackingEnabled, Order = 13)]
    public bool IsChangesTrackingEnabled { get; set; }

    [DataMember(Name = ApiConsts.Members.ItemSource, Order = 17)]
    public ItemAuthoringMode ItemSource { get; set; }
}