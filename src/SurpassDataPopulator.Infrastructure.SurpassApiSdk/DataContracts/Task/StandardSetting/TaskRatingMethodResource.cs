using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting
{
    [DataContract(Name = ApiConsts.Contracts.TaskRatingMethod, Namespace = "")]
    public class TaskRatingMethodResource
    {
        [DataMember(Name = ApiConsts.Members.RatingMethod)]
        public RatingMethodDetailedResource RatingMethod { get; set; }

        [DataMember(Name = ApiConsts.Members.RatingMethodOptions)]
        public ICollection<TaskRatingMethodOptionResource> Options { get; set; }
    }
}
