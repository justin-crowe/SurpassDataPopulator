using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Base.Interfaces;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.ItemReview;

[ControllerName(ApiConsts.Segments.ItemReviewResult, 2)]
[DataContract(Name = ApiConsts.Contracts.ItemReviewResult, Namespace = "")]
public class ItemReviewResultResource : ILinkedIdResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
    public long? Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Href, Order = 1)]
    [NotSortable]
    [NotFilterable]
    public string Href { get; set; }
}