using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Base;

/// <summary>
/// Represents a simple resource with Id and Reference
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
public class Resource : ReferenceResource
{
    /// <summary>
    /// Resource Id
    /// </summary>
    [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
    public long? Id { get; set; }
}