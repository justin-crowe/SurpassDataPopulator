using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting;

[DataContract(Name = ApiConsts.Contracts.StandardSettingTask, Namespace = "")]
public class StandardSettingTaskCreateResource : TaskCreateExtendedResource
{
    [DataMember(Name = ApiConsts.Members.NavigationType, Order = 9)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public NavigationType NavigationType { get; set; }

    [DataMember(Name = ApiConsts.Members.RatingMethods, Order = 10)]
    public ICollection<TaskRatingMethodUpdateResource> RatingMethods { get; set; }
}