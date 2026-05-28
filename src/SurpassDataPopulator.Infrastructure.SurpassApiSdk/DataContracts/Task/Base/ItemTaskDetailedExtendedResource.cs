using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.Base;

[DataContract(Namespace = "")]
public abstract class ItemTaskDetailedExtendedResource : TaskDetailedExtendedResource
{
    [DataMember(Name = ApiConsts.Members.ItemList, Order = 11)]
    public TaskItemListExtendedResource ItemList { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskExecutors, Order = 12)]
    public IEnumerable<TaskExecutorExtendedResource> Executors { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskProfile, Order = 15)]
    public TaskProfileResource TaskProfile { get; set; }
}