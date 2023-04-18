using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting
{
    [DataContract(Name = ApiConsts.Contracts.StandardSettingTask, Namespace = "")]
    [ControllerName(ApiConsts.Segments.StandardSettingTask, 2)]
    public class StandardSettingTaskDetailedResource : ItemTaskDetailedResourceBase
    {
        [DataMember(Name = ApiConsts.Members.TaskProfile, Order = 12)]
        public TaskProfileResource TaskProfile { get; set; }

        [DataMember(Name = ApiConsts.Members.NavigationType, Order = 13)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public NavigationType NavigationType { get; set; }

        [DataMember(Name = ApiConsts.Members.RatingMethods, Order = 14)]
        public ICollection<TaskRatingMethodResource> RatingMethods { get; set; }
    }
}
