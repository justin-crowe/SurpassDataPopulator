using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.General;

[DataContract(Name = ApiConsts.Contracts.GeneralTask, Namespace = "")]
public class GeneralTaskUpdateResource : TaskUpdateResource
{
    [DataMember(Name = ApiConsts.Members.TaskStatus, Order = 5)]
    public TaskStatus? TaskStatus { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskExecutor, Order = 6)]
    public Resource Executor { get; set; }
}