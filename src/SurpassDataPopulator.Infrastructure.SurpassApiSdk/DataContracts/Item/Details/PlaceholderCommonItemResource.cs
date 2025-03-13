using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details;

[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class PlaceholderCommonItemResource
{
    [DataMember(Name = ApiConsts.Members.PlaceholderText, EmitDefaultValue = true)]
    public string PlaceholderText { get; set; }

    [DataMember(Name = ApiConsts.Members.Placeholders, EmitDefaultValue = true)]
    public IEnumerable<PlaceholderResource> Placeholders { get; set; }

    [DataMember(Name = ApiConsts.Members.AwardAllCorrect, EmitDefaultValue = true)]
    public bool? AwardAllCorrect { get; set; }
}