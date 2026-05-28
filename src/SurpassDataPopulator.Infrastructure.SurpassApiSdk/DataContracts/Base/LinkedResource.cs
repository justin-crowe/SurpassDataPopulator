using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Base.Interfaces;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Base;

/// <summary>
/// Represents a <see cref="Resource"/> that has href property
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
public class LinkedResource : Resource, ILinkedIdResource
{
    /// <summary>
    /// Resource Href
    /// </summary>
    [DataMember(Name = ApiConsts.Members.Href, Order = 2)]
    [NotSortable]
    [NotFilterable]
    public string Href { get; set; }
}