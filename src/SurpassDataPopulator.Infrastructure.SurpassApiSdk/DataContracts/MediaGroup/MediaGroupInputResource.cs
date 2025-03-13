using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.MediaGroup;

[DataContract(Name = ApiConsts.Contracts.MediaGroup, Namespace = "")]
public class MediaGroupInputResource : BaseMediaGroupResource
{
    [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false)]
    public ItemSubjectResource Subject { get; set; }
}