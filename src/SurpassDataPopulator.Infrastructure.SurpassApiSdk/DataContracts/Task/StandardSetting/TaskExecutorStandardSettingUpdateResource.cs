using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting
{
    [DataContract(Name = ApiConsts.Members.TaskExecutors, Namespace = "")]
    public class TaskExecutorStandardSettingUpdateResource : TaskExecutorCreateUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.TaskStatus, Order = 3)]
        public TaskStatus? Status { get; set; }
    }
}
