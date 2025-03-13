using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.ItemAuthoring;

[DataContract(Name = ApiConsts.Contracts.ItemAuthoringTask, Namespace = "")]
public class ItemAuthoringTaskCreateResource : TaskCreateHistoryAndStatusSupportedResource
{
    [DataMember(Name = ApiConsts.Members.IsChangesTrackingEnabled, Order = 9)]
    public bool IsChangesTrackingEnabled { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskSubjectId, Order = 11)]
    public int TaskSubjectId { get; set; }
}