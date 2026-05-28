using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details;

[ControllerName(ApiConsts.Segments.AssistiveMedia, 2)]
[DataContract(Name = ApiConsts.Contracts.AssistiveMedia, Namespace = "")]
public sealed class AssistiveMediaInputResource
{
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Data, EmitDefaultValue = false)]
    public byte[] Data { get; set; }
}