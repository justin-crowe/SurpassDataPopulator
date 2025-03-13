using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.Base;

[DataContract(Namespace = "")]
public abstract class ItemTaskDetailedResourceBase : TaskDetailedResource
{
    [DataMember(Name = ApiConsts.Members.ItemList, Order = 10)]
    public TaskItemListExtendedResource ItemList { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskExecutors, Order = 11)]
    public IEnumerable<TaskExecutorResource> Executors { get; set; }
}