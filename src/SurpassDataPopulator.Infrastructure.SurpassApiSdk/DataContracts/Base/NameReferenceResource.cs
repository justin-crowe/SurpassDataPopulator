using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Base;

/// <summary>
/// Represents a named <see cref="Resource"/>
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
public class NameReferenceResource : ReferenceResource
{
    /// <summary>
    /// Resource name
    /// </summary>
    [DataMember(Name = ApiConsts.Members.Name, Order = 3)]
    public string Name { get; set; }
}