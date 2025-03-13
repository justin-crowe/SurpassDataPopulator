using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.DataContracts.WorkflowStatus;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.ItemReview;

[DataContract(Name = ApiConsts.Contracts.ItemReviewTask, Namespace = "")]
public class ItemReviewTaskUpdateResource : TaskUpdateResource
{
    [DataMember(Name = ApiConsts.Members.ItemList, Order = 5)]
    public ItemReviewItemListResource ItemList { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskExecutors, Order = 6)]
    public IEnumerable<TaskExecutorUpdateResource> Executors { get; set; }

    [DataMember(Name = ApiConsts.Members.ItemStatus, Order = 7)]
    public WorkflowStatusResource ItemStatus { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskProfile, Order = 8)]
    public TaskProfileResource TaskProfile { get; set; }

    [DataMember(Name = ApiConsts.Members.IsExtendedHistoryEnabled, Order = 9)]
    public bool? IsExtendedHistoryEnabled { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskStatus, Order = 10)]
    public TaskStatus? Status { get; set; }
}