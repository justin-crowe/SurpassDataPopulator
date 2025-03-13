using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details.Items;

[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class DragAndDropZoneOptionsResource
{
    [DataMember(Name = ApiConsts.Members.Options, EmitDefaultValue = true)]
    public IEnumerable<DragAndDropZoneOptionUpdateResource> Options { get; set; }
}