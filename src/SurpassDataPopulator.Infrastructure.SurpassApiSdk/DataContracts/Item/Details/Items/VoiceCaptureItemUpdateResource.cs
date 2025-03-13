using System.ComponentModel;
using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details.Items;

[CollectionSize(1)]
[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class VoiceCaptureItemUpdateResource
{
    [DefaultValue(30)]
    [DataMember(Name = ApiConsts.Members.TimeLength, EmitDefaultValue = true)]
    public int? TimeLength { get; set; }
}