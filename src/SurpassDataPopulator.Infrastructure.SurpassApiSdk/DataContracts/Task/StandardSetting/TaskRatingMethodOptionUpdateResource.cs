using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting;

[DataContract(Name = ApiConsts.Contracts.TaskRatingMethodOption, Namespace = "")]
public class TaskRatingMethodOptionUpdateResource
{
    [DataMember(Name = ApiConsts.Members.RatingMethodOption)]
    public RatingMethodOptionResource RatingMethodOption { get; set; }

    [DataMember(Name = ApiConsts.Members.Value)]
    public string Value { get; set; }
}