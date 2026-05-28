using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task;

[DataContract(Name = ApiConsts.Contracts.TaskUser, Namespace = "")]
public class TaskExecutorExtendedResource
{
    [DataMember(Name = ApiConsts.Members.TaskStatus, Order = 1)]
    public TaskStatus Status { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskExecutor, EmitDefaultValue = false, Order = 2)]
    public UserDetailedResource Executor { get; set; }
}