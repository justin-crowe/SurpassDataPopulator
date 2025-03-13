using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestProfile.Details;

[DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
public class TestProfileManifestFileInputResource
{
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Manifest, EmitDefaultValue = true)]
    public byte[] Manifest { get; set; }
}