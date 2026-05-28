using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestProfile.Details;

[DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
public class TestProfileLogoResource
{
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Image, EmitDefaultValue = true)]
    public byte[] Logo { get; set; }

    public bool IsValidImage()
    {
        return Logo != null && !string.IsNullOrEmpty(Name);
    }
}