using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details.Items;

[CollectionSize(1)]
[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class NumericalEntryItemUpdateResource
{
    [DataMember(Name = ApiConsts.Members.SpecificValue, EmitDefaultValue = true)]
    public double? SpecificValue { get; set; }

    [DataMember(Name = ApiConsts.Members.Range, EmitDefaultValue = true)]
    public RangeResource Range { get; set; }

    [DataMember(Name = ApiConsts.Members.DecimalSeparator, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DecimalSeparatorKey? DecimalSeparator { get; set; }
}