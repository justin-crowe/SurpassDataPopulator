using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagValue;

public class TagValueGroupResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 0, EmitDefaultValue = true)]
    public long Id { get; set; }
}