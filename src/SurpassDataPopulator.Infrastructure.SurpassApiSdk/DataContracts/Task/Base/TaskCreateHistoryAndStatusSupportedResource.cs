using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.WorkflowStatus;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.Base;

[DataContract(Name = ApiConsts.Contracts.Task, Namespace = "")]
public abstract class TaskCreateHistoryAndStatusSupportedResource : TaskCreateExtendedResource
{
    [DataMember(Name = ApiConsts.Members.ItemStatus, Order = 7)]
    public WorkflowStatusResource ItemStatus { get; set; }

    [DataMember(Name = ApiConsts.Members.IsExtendedHistoryEnabled, Order = 12)]
    public bool IsExtendedHistoryEnabled { get; set; }
}