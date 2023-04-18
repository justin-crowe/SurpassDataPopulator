using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.Base
{
    [DataContract(Name = ApiConsts.Contracts.Task, Namespace = "")]
    public abstract class TaskCreateExtendedResource : TaskCreateResource
    {
        [DataMember(Name = ApiConsts.Members.ItemList, Order = 5)]
        public Resource ItemList { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskExecutors, Order = 6)]
        public IEnumerable<TaskExecutorCreateUpdateResource> Executors { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskProfile, Order = 8)]
        public TaskProfileResource TaskProfile { get; set; }

        [DataMember(Name = ApiConsts.Members.ItemSource, Order = 10)]
        public ItemAuthoringMode ItemSource { get; set; }

    }
}
