using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagValue;

/// <summary>
/// Represents a base tag value properties
/// </summary>
[DataContract(Name = ApiConsts.Contracts.TagValue, Namespace = "")]
public class TagValueInputResource
{
    [DataMember(Name = ApiConsts.Members.TagGroup, Order = 0, EmitDefaultValue = false)]
    public TagValueGroupResource TagGroup { get; set; }

    [DataMember(Name = ApiConsts.Members.TagValue, Order = 1, EmitDefaultValue = false)]
    public string TagValue { get; set; }
}