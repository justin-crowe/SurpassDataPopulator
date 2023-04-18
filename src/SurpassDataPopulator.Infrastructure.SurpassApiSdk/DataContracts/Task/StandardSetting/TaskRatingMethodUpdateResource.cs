using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting
{
    [DataContract(Name = ApiConsts.Contracts.TaskRatingMethod, Namespace = "")]
    public class TaskRatingMethodUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.RatingMethod)]
        public RatingMethodResource RatingMethod { get; set; }

        [DataMember(Name = ApiConsts.Members.RatingMethodOptions)]
        public ICollection<TaskRatingMethodOptionUpdateResource> Options { get; set; }
    }
}
