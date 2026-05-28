using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Permissions;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.User;

[DataContract(Name = ApiConsts.Contracts.User, Namespace = "")]
public class UserUpdateResource
{
    [DataMember(Name = ApiConsts.Members.FirstName, Order = 1)]
    public string FirstName { get; set; }

    [DataMember(Name = ApiConsts.Members.LastName, Order = 2)]
    public string LastName { get; set; }

    [DataMember(Name = ApiConsts.Members.SsoExternalId, Order = 3)]
    public string ExternalId { get; set; }

    [DataMember(Name = ApiConsts.Members.Email, Order = 4)]
    public string Email { get; set; }

    [DataMember(Name = ApiConsts.Members.JobTitle, Order = 5)]
    public string JobTitle { get; set; }

    [DataMember(Name = ApiConsts.Members.DefaultLanguage, Order = 6)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SurpassApiLanguageKey? DefaultLanguage { get; set; }

    [DataMember(Name = ApiConsts.Members.Retired, Order = 7)]
    public bool? Retired { get; set; }

    [DataMember(Name = ApiConsts.Members.ExpiryDate, Order = 8)]
    public DateTime? ExpiryDate { get; set; }

    [DataMember(Name = ApiConsts.Members.UserPermissions, Order = 9)]
    public IList<CentreSubjectRoleCreateResource> UserRoles { get; set; }
}