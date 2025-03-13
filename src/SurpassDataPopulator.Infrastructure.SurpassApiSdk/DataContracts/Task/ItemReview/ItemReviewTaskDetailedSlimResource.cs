using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.ItemReview;

[DataContract(Name = ApiConsts.Contracts.ItemReviewTask, Namespace = "")]
[ControllerName(ApiConsts.Segments.ItemReviewTask, 2)]
public class ItemReviewTaskDetailedSlimResource : ItemTaskDetailedSlimResource
{
    [DataMember(Name = ApiConsts.Members.AllowEditItems, Order = 12)]
    public bool AllowEditItems { get; set; }

    [DataMember(Name = ApiConsts.Members.ReviewType, Order = 14)]
    public ReviewType ReviewType { get; set; }
}