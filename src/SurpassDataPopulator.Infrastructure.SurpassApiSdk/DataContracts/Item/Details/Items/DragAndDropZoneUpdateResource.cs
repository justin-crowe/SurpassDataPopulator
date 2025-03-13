using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details.Items;

[DataContract(Name = ApiConsts.Contracts.Zone, Namespace = "")]
public class DragAndDropZoneUpdateResource
{
    [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
    public long? Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Title, EmitDefaultValue = true)]
    public string Title { get; set; }

    [DataMember(Name = ApiConsts.Members.DragOptions, EmitDefaultValue = true)]
    public IEnumerable<DragAndDropZoneOptionUpdateResource> Options { get; set; }

    [DataMember(Name = ApiConsts.Members.XAxis, EmitDefaultValue = true)]
    public int? X { get; set; }

    [DataMember(Name = ApiConsts.Members.YAxis, EmitDefaultValue = true)]
    public int? Y { get; set; }

    [DataMember(Name = ApiConsts.Members.Height, EmitDefaultValue = true)]
    public int? Height { get; set; }

    [DataMember(Name = ApiConsts.Members.Width, EmitDefaultValue = true)]
    public int? Width { get; set; }
}