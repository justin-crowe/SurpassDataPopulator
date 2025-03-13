using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Base;

/// <summary>
/// Represents a <see cref="Resource"/> that has name property
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
public class NamedResource : Resource
{
    /// <summary>
    /// Resource name
    /// </summary>
    [DataMember(Name = ApiConsts.Members.Name, Order = 3)]
    public string Name { get; set; }
}