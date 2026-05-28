using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.ItemReview;

[DataContract(Name = ApiConsts.Contracts.ItemReviewTask, Namespace = "")]
public class ItemReviewTaskCreateResource : TaskCreateHistoryAndStatusSupportedResource
{
    [DataMember(Name = ApiConsts.Members.AllowEditItems, Order = 8)]
    public bool AllowEditItems { get; set; }

    [DataMember(Name = ApiConsts.Members.IsChangesTrackingEnabled, Order = 9)]
    public bool IsChangesTrackingEnabled { get; set; }

    [DataMember(Name = ApiConsts.Members.ReviewType, Order = 10)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ReviewType ReviewType { get; set; }
}