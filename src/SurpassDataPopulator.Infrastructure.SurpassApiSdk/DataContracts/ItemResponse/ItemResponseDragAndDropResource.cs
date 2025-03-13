using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class ItemResponseDragAndDropResource : ItemResponseBaseResource
{
    [DataMember(Name = ApiConsts.Members.Marking, Order = 6)]
    public string Marking { get; set; }

    [DataMember(Name = ApiConsts.Members.WeightedMarking, Order = 7)]
    public bool WeightedMarking { get; set; }

    [DataMember(Name = ApiConsts.Members.DropZones, Order = 8)]
    public IEnumerable<DropZoneResource> DropZones { get; set; }

    [DataMember(Name = ApiConsts.Members.UnassignedDragOptions, Order = 9)]
    public IEnumerable<BaseItemResponseDragItemResource> UnassignedDragOptions { get; set; }
}