using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.TagCategory;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TagGroup;

/// <summary>
/// Represents a base tag group properties
/// </summary>
[ControllerName(ApiConsts.Segments.TagGroup, 2)]
[DataContract(Name = ApiConsts.Contracts.TagGroup, Namespace = "")]
public class TagGroupBaseResource
{
    [DataMember(Name = ApiConsts.Members.Name, Order = 0, EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.AllowMultipleTags, EmitDefaultValue = false)]
    public bool? AllowMultipleTags { get; set; }

    [DefaultValue(false)]
    [DataMember(Name = ApiConsts.Members.IsCollectable, EmitDefaultValue = true)]
    public bool? IsCollectable { get; set; }

    [DefaultValue(true)]
    [DataMember(Name = ApiConsts.Members.IsPublishable, EmitDefaultValue = true)]
    public bool? IsPublishable { get; set; }

    [DataMember(Name = ApiConsts.Members.AuthorCreation, EmitDefaultValue = false)]
    public bool? AuthorCreation { get; set; }

    [DataMember(Name = ApiConsts.Members.ReadonlyTagGroup, EmitDefaultValue = true)]
    [DefaultValue(false)]
    public bool? Readonly { get; set; }

    [DefaultValue(TagGroupTagTypeValueKey.Text)]
    [DataMember(Name = ApiConsts.Members.TagTypeValue)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TagGroupTagTypeValueKey? TagTypeValue { get; set; }

    [DataMember(Name = ApiConsts.Members.NumericTagProperties, EmitDefaultValue = false)]
    public TagGroupRestrictionsResource NumericTagProperties { get; set; }

    [DataMember(Name = ApiConsts.Members.TagCategories)]
    public List<TagCategoryIdResource> TagCategories { get; set; }
}