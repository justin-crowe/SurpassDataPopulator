using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting
{
    [DataContract(Name = ApiConsts.Contracts.StandardSettingTask, Namespace = "")]
    public class StandardSettingTaskUpdateResource : TaskUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.ItemList, Order = 5)]
        public StandardSettingItemListResource ItemList { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskExecutors, Order = 6)]
        public IEnumerable<TaskExecutorStandardSettingUpdateResource> Executors { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskProfile, Order = 7)]
        public TaskProfileResource TaskProfile { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskStatus, Order = 8)]
        public TaskStatus? Status { get; set; }

        [DataMember(Name = ApiConsts.Members.NavigationType, Order = 9)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public NavigationType? NavigationType { get; set; }

        [DataMember(Name = ApiConsts.Members.RatingMethods, Order = 10)]
        public ICollection<TaskRatingMethodUpdateResource> RatingMethods { get; set; }
    }
}
