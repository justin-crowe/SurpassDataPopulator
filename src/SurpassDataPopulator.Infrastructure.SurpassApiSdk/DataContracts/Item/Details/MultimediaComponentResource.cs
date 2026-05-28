using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details;

[CollectionSize(2)]
[DataContract(Name = ApiConsts.Contracts.ItemOption, Namespace = "")]
public class MultimediaComponentResource : MultimediaBaseComponentResource
{
    [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
    public long Id { get; set; }
}