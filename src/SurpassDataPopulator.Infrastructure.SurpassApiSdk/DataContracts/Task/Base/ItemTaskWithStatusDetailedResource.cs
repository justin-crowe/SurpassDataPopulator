using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.WorkflowStatus;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.Base;

[DataContract(Namespace = "")]
public abstract class ItemTaskWithStatusDetailedResource : ItemTaskDetailedExtendedResource
{
    [DataMember(Name = ApiConsts.Members.ItemStatus, Order = 10)]
    public WorkflowStatusResource ItemStatus { get; set; }
}