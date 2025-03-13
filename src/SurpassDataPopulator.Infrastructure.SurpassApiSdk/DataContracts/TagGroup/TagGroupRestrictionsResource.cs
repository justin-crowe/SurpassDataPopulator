using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.TagGroup;

[DataContract(Name = ApiConsts.Contracts.TagGroupRestrictions, Namespace = "")]
public class TagGroupRestrictionsResource
{
    [DefaultValue(SurpassApiSubjectNumericTagType.Custom)]
    [DataMember(Name = ApiConsts.Members.TagGroupRestrictionsType, Order = 1)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SurpassApiSubjectNumericTagType Type { get; set; }

    [DefaultValue(null)]
    [DataMember(Name = ApiConsts.Members.Boundary, Order = 2)]
    public decimal? Boundary { get; set; }

    [DefaultValue(null)]
    [DataMember(Name = ApiConsts.Members.LowerBoundary, Order = 3)]
    public decimal? LowerBoundary { get; set; }

    [DefaultValue(null)]
    [DataMember(Name = ApiConsts.Members.UpperBoundary, Order = 4)]
    public decimal? UpperBoundary { get; set; }

    [DefaultValue(false)]
    [DataMember(Name = ApiConsts.Members.TagGroupRestrictionsAllowDecimalPlaces, Order = 5)]
    public bool AllowDecimalPlaces { get; set; }
}