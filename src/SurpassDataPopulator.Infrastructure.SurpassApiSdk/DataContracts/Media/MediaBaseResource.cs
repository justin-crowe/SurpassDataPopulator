using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Media;

[DataContract(Name = ApiConsts.Contracts.Media, Namespace = "")]
public class MediaBaseResource
{
    [DataMember(Name = ApiConsts.Members.Name, Order = 0, EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Description, Order = 1, EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = ApiConsts.Members.Data, EmitDefaultValue = false)]
    public byte[] Data { get; set; }

    [DataMember(Name = ApiConsts.Members.Group, EmitDefaultValue = true)]
    public IdResource Group { get; set; }
}