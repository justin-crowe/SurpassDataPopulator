using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Permissions;

/// <summary>
/// Represents a permission that has name property
/// </summary>
[ControllerName(ApiConsts.Segments.Permission, 2)]
[DataContract(Name = ApiConsts.Contracts.Permission, Namespace = "")]
public class RoleTypeResource : NamedResource
{
}