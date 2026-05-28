using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details.Items;

[DataContract(Name = ApiConsts.Contracts.Option, Namespace = "")]
public class DragAndDropZoneOptionUpdateResource
{
    [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
    public long? Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Text, EmitDefaultValue = true)]
    public string Text { get; set; }

    [DataMember(Name = ApiConsts.Members.MediaItem, EmitDefaultValue = true)]
    public MediaItemDetailResource Media { get; set; }
}