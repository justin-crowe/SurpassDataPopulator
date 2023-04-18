using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.ItemReview
{
    [DataContract(Name = ApiConsts.Members.TaskExecutors, Namespace = "")]
    public class TaskExecutorUpdateResource : TaskExecutorCreateUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.TaskStatus, Order = 3)]
        public TaskStatus? Status { get; set; }
    }
}
