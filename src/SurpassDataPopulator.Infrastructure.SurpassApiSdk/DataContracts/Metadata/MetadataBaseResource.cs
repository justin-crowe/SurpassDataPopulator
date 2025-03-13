using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Metadata;

[DataContract(Name = ApiConsts.Contracts.Metadata, Namespace = "")]
[ControllerName(ApiConsts.Members.Metadata, 2)]
public class MetadataBaseResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.FileName, Order = 3)]
    public string FileName { get; set; }
}