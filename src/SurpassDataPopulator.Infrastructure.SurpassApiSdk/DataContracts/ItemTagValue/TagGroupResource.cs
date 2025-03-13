using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemTagValue;

public class TagGroupResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 0, EmitDefaultValue = false)]
    public long Id { get; set; }
}