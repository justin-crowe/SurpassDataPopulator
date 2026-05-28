using System.ComponentModel;
using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item;

[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
[ControllerName(ApiConsts.Segments.Item, 2)]
public class ItemUpdateResource : BaseItemResource
{
    [DataMember(Name = ApiConsts.Members.AssistiveMedia, EmitDefaultValue = true)]
    public AssistiveMediaInputResource AssistiveMedia { get; set; }

    [DataMember(Name = ApiConsts.Members.IsMultipleChange, EmitDefaultValue = true)]
    [DefaultValue(false)]
    public bool IsMultipleChange { get; set; }

    /// <summary>
    /// For internal usage in controller
    /// </summary>
    public int? LanguageParentId { get; set; }
}