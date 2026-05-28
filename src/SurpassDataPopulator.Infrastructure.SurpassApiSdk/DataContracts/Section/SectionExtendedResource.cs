using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Section.Interfaces;
using SurpassApiSdk.DataContracts.TestForm;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Section;

[DataContract(Name = ApiConsts.Contracts.Section, Namespace = "")]
[ControllerName(ApiConsts.Members.Section, 2)]
public class SectionExtendedResource : SectionBaseResource, ISectionExtendedResource
{
    [DataMember(Name = ApiConsts.Members.SectionType, EmitDefaultValue = false, Order = 4)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SectionType Type { get; set; }

    [DataMember(Name = ApiConsts.Members.ItemsCount, EmitDefaultValue = false, Order = 5)]
    public int? ItemsCount { get; set; }

    [DataMember(Name = ApiConsts.Members.Items, EmitDefaultValue = false, Order = 6)]
    public List<TestFormSectionItemBaseResource> SectionItems { get; set; }

    [DataMember(Name = ApiConsts.Members.Projects, EmitDefaultValue = false, Order = 7)]
    public List<long> Projects { get; set; }
}