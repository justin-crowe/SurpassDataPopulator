using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details;

[DataContract(Name = ApiConsts.Contracts.AssistiveMedia, Namespace = "")]
public sealed class AssistiveMediaResource : AssistiveMediaLinkedResource
{
    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Data)]
    public byte[] Data { get; set; }
}