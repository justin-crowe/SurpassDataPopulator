using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.WorkflowStatus;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.Base
{
    [DataContract(Namespace = "")]
    public abstract class ItemTaskWithStatusAndHistoryDetailedResource : ItemTaskDetailedResourceBase
    {
        [DataMember(Name = ApiConsts.Members.ItemStatus, Order = 9)]
        public WorkflowStatusResource ItemStatus { get; set; }

        [DataMember(Name = ApiConsts.Members.IsExtendedHistoryEnabled, Order = 15)]
        public bool? IsExtendedHistoryEnabled { get; set; }
    }
}
