using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ClientInformation;

[DataContract(Name = ApiConsts.Segments.ClientInformation, Namespace = "")]
[ControllerName(ApiConsts.Segments.ClientInformation, 2)]
public class ClientInformationResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.Value, EmitDefaultValue = true, Order = 4)]
    public string Value { get; set; }
}