using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Test.Details;

[DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
public class TestUserAssociationsResource
{
    [DataMember(Name = ApiConsts.Members.RestrictUserAccess, EmitDefaultValue = true)]
    public bool RestrictUserAccess { get; set; }

    [DataMember(Name = ApiConsts.Members.EnableMarker, EmitDefaultValue = true)]
    public bool EnableMarker { get; set; }

    [DataMember(Name = ApiConsts.Members.RequireMarker, EmitDefaultValue = true)]
    public bool RequireMarker { get; set; }

    [DataMember(Name = ApiConsts.Members.EnableModerator, EmitDefaultValue = true)]
    public bool EnableModerator { get; set; }

    [DataMember(Name = ApiConsts.Members.RequireModerator, EmitDefaultValue = true)]
    public bool RequireModerator { get; set; }
}