using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagValue;

[DataContract(Name = ApiConsts.Contracts.TagValue, Namespace = "")]
public class TagValueManyResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.TagValue, EmitDefaultValue = true)]
    public string TagValue { get; set; }
}