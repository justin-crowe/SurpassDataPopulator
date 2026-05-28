using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.DataContracts.WorkflowStatus;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.ItemAuthoring;

[DataContract(Name = ApiConsts.Contracts.ItemAuthoringTask, Namespace = "")]
public class ItemAuthoringTaskUpdateResource
{
    [DataMember(Name = ApiConsts.Members.Name, Order = 0)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Description, Order = 1)]
    public string Description { get; set; }

    [CustomGenerator("Date")]
    [DataMember(Name = ApiConsts.Members.StartDate, Order = 2)]
    public DateTime? StartDate { get; set; }

    [CustomGenerator("Date")]
    [DataMember(Name = ApiConsts.Members.ExpiryDate, Order = 3)]
    public DateTime? ExpiryDate { get; set; }

    [DataMember(Name = ApiConsts.Members.ItemStatus, Order = 4)]
    public WorkflowStatusResource ItemStatus { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskExecutors, Order = 5)]
    public IEnumerable<TaskExecutorCreateUpdateResource> Executors { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskProfile, Order = 6)]
    public TaskProfileResource TaskProfile { get; set; }

    [DataMember(Name = ApiConsts.Members.IsExtendedHistoryEnabled, Order = 7)]
    public bool? IsExtendedHistoryEnabled { get; set; }

    [DataMember(Name = ApiConsts.Members.ItemSource, Order = 8)]
    public ItemAuthoringMode? ItemSource { get; set; }
}