using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.MediaGroup;

[DataContract(Name = ApiConsts.Contracts.MediaGroup, Namespace = "")]
public class BaseMediaGroupResource
{
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Description, EmitDefaultValue = true)]
    public string Description { get; set; }

    [DataMember(Name = ApiConsts.Members.Media, EmitDefaultValue = true)]
    public IList<IdResource> Media { get; set; }
}