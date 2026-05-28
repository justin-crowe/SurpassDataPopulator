using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.UserPermission;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.User;

[DataContract(Name = ApiConsts.Contracts.User, Namespace = "")]
[ControllerName(ApiConsts.Segments.User, 2)]
public class UserDetailedInternalResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
    public long? Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Reference, EmitDefaultValue = false, Order = 1)]
    public virtual string Reference { get; set; }

    [DataMember(Name = ApiConsts.Members.Href, Order = 2)]
    [NotSortable]
    [NotFilterable]
    public string Href { get; set; }

    [DataMember(Name = ApiConsts.Members.FirstName, EmitDefaultValue = false, Order = 3)]
    public string FirstName { get; set; }

    [DataMember(Name = ApiConsts.Members.LastName, EmitDefaultValue = false, Order = 4)]
    public string LastName { get; set; }

    [DataMember(Name = ApiConsts.Members.SsoExternalId, EmitDefaultValue = false, Order = 5)]
    public string ExternalId { get; set; }

    [DataMember(Name = ApiConsts.Members.Email, EmitDefaultValue = false, Order = 6)]
    public string Email { get; set; }

    [DataMember(Name = ApiConsts.Members.JobTitle, EmitDefaultValue = false, Order = 7)]
    public string JobTitle { get; set; }

    [DataMember(Name = ApiConsts.Members.DefaultLanguage, EmitDefaultValue = false, Order = 8)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SurpassApiLanguageKey? DefaultLanguage { get; set; }

    [DataMember(Name = ApiConsts.Members.DateCreated, EmitDefaultValue = false, Order = 9)]
    public DateTime? DateCreated { get; set; }

    [DataMember(Name = ApiConsts.Members.Retired, EmitDefaultValue = false, Order = 10)]
    public bool? Retired { get; set; }

    [DataMember(Name = ApiConsts.Members.ExpiryDate, EmitDefaultValue = false, Order = 11)]
    public DateTime? ExpiryDate { get; set; }

    [DataMember(Name = ApiConsts.Members.UserPermissions, EmitDefaultValue = false, Order = 12)]
    public IEnumerable<UserRoleBaseResource> UserRoles { get; set; }

    [DataMember(Name = ApiConsts.Members.UserName, EmitDefaultValue = false, Order = 13)]
    public string UserName { get; set; }
}