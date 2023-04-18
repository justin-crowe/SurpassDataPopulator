using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.UserPermission;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.User
{
    [DataContract(Name = ApiConsts.Contracts.User, Namespace = "")]
    [ControllerName(ApiConsts.Segments.User, 2)]
    public class UserDetailedResource : UserResource
    {
        [DataMember(Name = ApiConsts.Members.FirstName, Order = 3)]
        public string FirstName { get; set; }

        [DataMember(Name = ApiConsts.Members.LastName, Order = 4)]
        public string LastName { get; set; }

        [DataMember(Name = ApiConsts.Members.SsoExternalId, Order = 5)]
        public string ExternalId { get; set; }

        [DataMember(Name = ApiConsts.Members.Email, Order = 6)]
        public string Email { get; set; }

        [DataMember(Name = ApiConsts.Members.JobTitle, Order = 7)]
        public string JobTitle { get; set; }

        [DataMember(Name = ApiConsts.Members.DefaultLanguage, Order = 8)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SurpassApiLanguageKey DefaultLanguage { get; set; }

        [DataMember(Name = ApiConsts.Members.DateCreated, Order = 9)]
        public DateTime DateCreated { get; set; }

        [DataMember(Name = ApiConsts.Members.Retired, Order = 10)]
        public bool Retired { get; set; }

        [DataMember(Name = ApiConsts.Members.ExpiryDate, Order = 11)]
        public DateTime ExpiryDate { get; set; }

        [DataMember(Name = ApiConsts.Members.UserPermissions, EmitDefaultValue = false, Order = 12)]
        public IEnumerable<UserRoleBaseResource> UserRoles { get; set; }
    }
}
