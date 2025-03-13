using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details.Items;

[CollectionSize(1)]
[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class ShortAnswerItemUpdateResource
{
    [DataMember(Name = ApiConsts.Members.RequireCaseSensitive, EmitDefaultValue = true)]
    public bool? RequireCaseSensitive { get; set; }

    [DataMember(Name = ApiConsts.Members.LimitCandidateResponse, EmitDefaultValue = true)]
    public bool? LimitCandidateResponse { get; set; }

    [DataMember(Name = ApiConsts.Members.MaxCharacterCount, EmitDefaultValue = true)]
    public int? MaxCharacterCount { get; set; }

    [DataMember(Name = ApiConsts.Members.AnswerList, EmitDefaultValue = true)]
    public ShortAnswerListResource AnswerList { get; set; }

    [DataMember(Name = ApiConsts.Members.Placeholders, EmitDefaultValue = true, Order = 4)]
    public IEnumerable<ShortAnswerPlaceholderResource> Placeholders { get; set; }

    [DataMember(Name = ApiConsts.Members.PlaceholderText, EmitDefaultValue = true)]
    public string PlaceholderText { get; set; }

    [DataMember(Name = ApiConsts.Members.AwardAllCorrect, EmitDefaultValue = true)]
    public bool? AwardAllCorrect { get; set; }
}