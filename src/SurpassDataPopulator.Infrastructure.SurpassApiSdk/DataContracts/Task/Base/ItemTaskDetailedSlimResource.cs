using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemList;
using SurpassApiSdk.DataContracts.WorkflowStatus;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.Base;

[DataContract(Namespace = "")]
public abstract class ItemTaskDetailedSlimResource : TaskDetailedSlimResource
{
    [DataMember(Name = ApiConsts.Members.ItemList, Order = 10)]
    public ItemListResource ItemList { get; set; }

    [DataMember(Name = ApiConsts.Members.ItemStatus, Order = 11)]
    public WorkflowStatusResource ItemStatus { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskExecutors, Order = 12)]
    public IEnumerable<TaskExecutorSlimResource> Executors { get; set; }

    [DataMember(Name = ApiConsts.Members.IsExtendedHistoryEnabled, Order = 15)]
    public bool IsExtendedHistoryEnabled { get; set; }

    [DataMember(Name = ApiConsts.Members.IsChangesTrackingEnabled, Order = 16)]
    public bool IsChangesTrackingEnabled { get; set; }
}