using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.ItemList;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting
{
    [DataContract(Name = ApiConsts.Contracts.StandardSettingTask, Namespace = "")]
    [ControllerName(ApiConsts.Segments.StandardSettingTask, 2)]
    public class StandardSettingTaskDetailedSlimResource : TaskDetailedSlimResource
    {
        [DataMember(Name = ApiConsts.Members.ItemList, Order = 11)]
        public ItemListResource ItemList { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskExecutors, Order = 12)]
        public IEnumerable<TaskExecutorSlimResource> Executors { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskProfile, Order = 13)]
        public TaskProfileResource TaskProfile { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskAttachments, Order = 14)]
        public IEnumerable<TaskAttachmentResource> Attachments { get; set; }

        [DataMember(Name = ApiConsts.Members.NavigationType, Order = 15)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public NavigationType NavigationType { get; set; }

        [DataMember(Name = ApiConsts.Members.RatingMethods, Order = 16)]
        public ICollection<TaskRatingMethodResource> RatingMethods { get; set; }
    }
}
