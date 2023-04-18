using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.General
{
    [DataContract(Name = ApiConsts.Contracts.GeneralTask, Namespace = "")]
    [ControllerName(ApiConsts.Segments.GeneralTask, 2)]
    public class GeneralTaskDetailedResource : TaskDetailedResource
    {
        [DataMember(Name = ApiConsts.Members.TaskExecutor, EmitDefaultValue = false, Order = 10)]
        public UserDetailedInternalResource Executor { get; set; }
    }
}
