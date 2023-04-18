using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.ItemReview
{
    [ControllerName(ApiConsts.Segments.ItemReviewTask, 2)]
    [DataContract(Name = ApiConsts.Contracts.ItemReviewResult, Namespace = "")]
    public class ItemReviewResultUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.ReviewResult)]
        public ReviewResult? ReviewResult { get; set; }

        [DataMember(Name = ApiConsts.Members.ResultComment)]
        public string Comment { get; set; }

        [DataMember(Name = ApiConsts.Members.WorkFlowStatusId)]
        public int? WorkFlowStatusId { get; set; }

        [DataMember(Name = ApiConsts.Members.IsFlagged)]
        public bool? IsFlagged { get; set; }

        [DataMember(Name = ApiConsts.Members.IsSubmitted)]
        public bool? IsSubmitted { get; set; }

        [DataMember(Name = ApiConsts.Members.OverrideUserLock)]
        public bool OverrideUserLock { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskUserRole)]
        public TaskUserRole? Role { get; set; }

        [DataMember(Name = ApiConsts.Members.AlternativeOptions)]
        public IEnumerable<string> AlternativeOptions { get; set; }

        [DataMember(Name = ApiConsts.Members.DeleteRecommendation)]
        public DeleteRecommendation? DeleteRecommendation { get; set; }
    }
}
