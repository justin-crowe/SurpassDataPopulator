using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagValue;

[DataContract(Name = ApiConsts.Contracts.TagValue, Namespace = "")]
public class TagValueUpdateResource : TagValueInputResource
{
    [DataMember(Name = ApiConsts.Members.Deleted, Order = 2, EmitDefaultValue = false)]
    public bool? Deleted { get; set; }
}