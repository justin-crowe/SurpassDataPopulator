using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details;

[CollectionSize(2)]
[DataContract(Name = ApiConsts.Contracts.ItemOption, Namespace = "")]
public class MultimediaBaseComponentResource
{
    [DataMember(Name = ApiConsts.Members.Text, EmitDefaultValue = true)]
    public string Text { get; set; }

    [DataMember(Name = ApiConsts.Members.MathMl, EmitDefaultValue = true)]
    public string MathMl { get; set; }

    [DataMember(Name = ApiConsts.Members.Media, EmitDefaultValue = true)]
    public MediaItemDetailResource Media { get; set; }
}