using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base.Interfaces;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.ItemReview
{
    [ControllerName(ApiConsts.Segments.ItemReviewResult, 2)]
    [DataContract(Name = ApiConsts.Contracts.ItemReviewResult, Namespace = "")]
    public class ItemReviewResultDetailedResource : ILinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public long? Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Href, Order = 1)]
        public string Href { get; set; }

        [DataMember(Name = ApiConsts.Members.ExternalItemId, Order = 2)]
        public long ExternalItemId { get; set; }

        [DataMember(Name = ApiConsts.Members.ExternalItemVersion, EmitDefaultValue = false, Order = 3)]
        public string ExternalItemVersion { get; set; }

        [DataMember(Name = ApiConsts.Members.ExternalSubjectId, Order = 4)]
        public long ExternalSubjectId { get; set; }

        [DataMember(Name = ApiConsts.Members.ReviewResult, EmitDefaultValue = false, Order = 5)]
        public ReviewResult? ReviewResult { get; set; }

        [DataMember(Name = ApiConsts.Members.ResultComment, EmitDefaultValue = false, Order = 6)]
        public string Comment { get; set; }

        [DataMember(Name = ApiConsts.Members.ResultLastModifiedDate, Order = 7)]
        public DateTime LastModifiedDate { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskExecutor, Order = 8)]
        public UserResource TaskExecutor { get; set; }

        [DataMember(Name = ApiConsts.Members.IsFinalDecision, Order = 9)]
        public bool IsFinalDecision { get; set; }

        [DataMember(Name = ApiConsts.Members.IsFlagged, Order = 10)]
        public bool IsFlagged { get; set; }

        [DataMember(Name = ApiConsts.Members.IsSubmitted, Order = 11)]
        public bool? IsSubmitted { get; set; }

        [DataMember(Name = ApiConsts.Members.CommentDate)]
        public DateTime? CommentDate { get; set; }

        [DataMember(Name = ApiConsts.Members.AlternativeOptions)]
        public IEnumerable<string> AlternativeOptions { get; set; }

        [DataMember(Name = ApiConsts.Members.DeleteRecommendation)]
        public DeleteRecommendation? DeleteRecommendation { get; set; }
    }
}
