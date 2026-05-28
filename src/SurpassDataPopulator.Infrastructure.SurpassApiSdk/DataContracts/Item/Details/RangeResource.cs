using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details;

[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class RangeResource
{
    [DataMember(Name = ApiConsts.Members.MinValue, EmitDefaultValue = true)]
    public double? MinValue { get; set; }

    [DataMember(Name = ApiConsts.Members.MaxValue, EmitDefaultValue = true)]
    public double? MaxValue { get; set; }
}