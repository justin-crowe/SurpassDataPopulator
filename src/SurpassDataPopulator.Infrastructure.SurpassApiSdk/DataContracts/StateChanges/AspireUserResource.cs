using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.StateChanges;

[DataContract(Name = ApiConsts.Contracts.User, Namespace = "")]
public class AspireUserResource
{
    [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true, Order = 551)]
    public string ID { get; set; }

    [DataMember(Name = ApiConsts.Members.Href, EmitDefaultValue = true, Order = 552)]
    public string Href { get; set; }
}