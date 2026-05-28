using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestProfile.Details;

[DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
public class TestProfileDetailImageResource
{
    [DataMember(Name = ApiConsts.Members.ImageId, EmitDefaultValue = true)]
    public int ImageId { get; set; }

    [DataMember(Name = ApiConsts.Members.ImageUrl, EmitDefaultValue = true)]
    public string ImageUrl { get; set; }

    [DataMember(Name = ApiConsts.Members.ImageName, EmitDefaultValue = true)]
    public string ImageName { get; set; }

    [DataMember(Name = ApiConsts.Members.TempImagePath, EmitDefaultValue = true)]
    public string TempImagePath { get; set; }
}