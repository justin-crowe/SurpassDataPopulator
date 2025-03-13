using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class BaseOptionModelResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 1, EmitDefaultValue = false)]
    public int Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Correct, Order = 2, EmitDefaultValue = true)]
    public bool? Correct { get; set; }

    [DataMember(Name = ApiConsts.Members.Selected, Order = 3, EmitDefaultValue = true)]
    public bool Selected { get; set; }

    [DataMember(Name = ApiConsts.Members.HtmlText, Order = 4, EmitDefaultValue = false)]
    public string HtmlText { get; set; }

    [DataMember(Name = ApiConsts.Members.Label, Order = 5, EmitDefaultValue = false)]
    public string Label { get; set; }
}