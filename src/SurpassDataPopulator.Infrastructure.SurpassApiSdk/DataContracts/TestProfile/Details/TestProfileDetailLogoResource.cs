using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestProfile.Details;

[DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
public class TestProfileDetailLogoResource
{
    [DataMember(Name = ApiConsts.Members.Color, EmitDefaultValue = true)]
    public TestProfileDetailImageResource Color { get; set; }

    [DataMember(Name = ApiConsts.Members.Monochrome, EmitDefaultValue = true)]
    public TestProfileDetailImageResource Monochrome { get; set; }
}