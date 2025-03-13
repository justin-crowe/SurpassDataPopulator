using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting;

[DataContract(Name = ApiConsts.Contracts.StandardSettingResult, Namespace = "")]
public class StandardSettingResultUpdateResource
{
    [DataMember(Name = ApiConsts.Members.IsFlagged)]
    public bool? IsFlagged { get; set; }

    [DataMember(Name = ApiConsts.Members.IsSubmitted)]
    public bool? IsSubmitted { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskUserRole)]
    public TaskUserRole? Role { get; set; }

    [DataMember(Name = ApiConsts.Members.RatingMethodResults)]
    public ICollection<TaskRatingMethodOptionUpdateResource> RatingMethodResults { get; set; }

    [DataMember(Name = ApiConsts.Members.ResultComment)]
    public string Comment { get; set; }
}