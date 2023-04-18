using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.General
{
    [DataContract(Name = ApiConsts.Contracts.GeneralTask, Namespace = "")]
    public class GeneralTaskCreateResource : TaskCreateResource
    {
        [DataMember(Name = ApiConsts.Members.TaskExecutor, Order = 5)]
        public Resource Executor { get; set; }

        [DataMember(Name = ApiConsts.Members.Subject, Order = 6)]
        public Resource Subject { get; set; }
    }
}
