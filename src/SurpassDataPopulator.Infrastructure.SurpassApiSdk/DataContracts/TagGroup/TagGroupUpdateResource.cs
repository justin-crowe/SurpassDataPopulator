using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagGroup;

/// <summary>
/// Represents a base tag group properties
/// </summary>
[DataContract(Name = ApiConsts.Contracts.TagGroup, Namespace = "")]
public class TagGroupUpdateResource : TagGroupBaseResource
{
}