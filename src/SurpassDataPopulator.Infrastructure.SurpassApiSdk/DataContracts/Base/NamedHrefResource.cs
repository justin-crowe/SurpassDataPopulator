using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Base;

[DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
public class NamedHrefResource : Resource
{
    /// <summary>
    /// Resource name
    /// </summary>
    [DataMember(Name = ApiConsts.Members.Name, Order = 3)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Href, Order = 4)]
    public string Href { get; set; }
}