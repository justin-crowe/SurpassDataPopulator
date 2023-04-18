using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.ItemReview
{
    [DataContract(Name = ApiConsts.Contracts.ItemReviewTask, Namespace = "")]
    [ControllerName(ApiConsts.Segments.ItemReviewTask, 2)]
    public class ItemReviewTaskDetailedResource : ItemTaskWithStatusAndHistoryDetailedResource
    {
        [DataMember(Name = ApiConsts.Members.AllowEditItems, Order = 12)]
        public bool AllowEditItems { get; set; }

        [DataMember(Name = ApiConsts.Members.IsChangesTrackingEnabled, Order = 13)]
        public bool IsChangesTrackingEnabled { get; set; }

        [DataMember(Name = ApiConsts.Members.ReviewType, Order = 14)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ReviewType ReviewType { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskProfile, Order = 15)]
        public TaskProfileResource TaskProfile { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowEditItemsByLeadAssignee, Order = 16)]
        public bool AllowEditItemsByLeadAssignee { get; set; }
    }
}
