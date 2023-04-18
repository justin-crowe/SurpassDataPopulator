using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting
{
    [DataContract(Name = ApiConsts.Contracts.TaskRatingMethodOption, Namespace = "")]
    public class TaskRatingMethodOptionResource
    {
        [DataMember(Name = ApiConsts.Members.RatingMethodOption)]
        public RatingMethodOptionDetailedResource RatingMethodOption { get; set; }

        [DataMember(Name = ApiConsts.Members.Value)]
        public string Value { get; set; }
    }
}
