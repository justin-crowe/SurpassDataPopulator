using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item.Enums;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details.Items;

[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class DragAndDropItemUpdateResource
{
    [DataMember(Name = ApiConsts.Members.AwardAllCorrect, EmitDefaultValue = true)]
    public bool? AwardAllCorrect { get; set; }

    [DataMember(Name = ApiConsts.Members.MaxItemsPerZoneType, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DragAndDropZoneType? MaxItemsPerZoneType { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomItemsPerZone, EmitDefaultValue = true)]
    public int? MaxDragOptionsPerZone { get; set; }

    [DataMember(Name = ApiConsts.Members.DndType, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DragAndDropType? Type { get; set; }

    [DataMember(Name = ApiConsts.Members.MarkType, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public MarkTypeKey? MarkType { get; set; }

    [DataMember(Name = ApiConsts.Members.DropZones, EmitDefaultValue = true)]
    public IList<DragAndDropZoneUpdateResource> Zones { get; set; }

    [DataMember(Name = ApiConsts.Members.AdditionalOptions, EmitDefaultValue = true)]
    public DragAndDropZoneOptionsResource AdditionalZone { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomMarks, EmitDefaultValue = true)]
    public IList<DragAndDropCustomMarksUpdateResource> CustomMarks { get; set; }

    [DataMember(Name = ApiConsts.Members.BackgroundImage, EmitDefaultValue = true)]
    public BackgroundImageResource BackgroundImage { get; set; }
}