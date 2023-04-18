using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Permissions
{
    [DataContract(Name = ApiConsts.Contracts.Permission, Namespace = "")]
    public class AnyLevelAssignableRoleStrippedResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public int Id { get; set; }

        [DataMember(Name = ApiConsts.Members.AssignableStripped, Order = 1)]
        public bool Assignable { get; set; }

        [DataMember(Name = ApiConsts.Members.CentreIdStripped, Order = 2, EmitDefaultValue = false)]
        public long? CentreId { get; set; }

        [DataMember(Name = ApiConsts.Members.SubjectIdStripped, Order = 3, EmitDefaultValue = false)]
        public long? SubjectId { get; set; }

        [DataMember(Name = ApiConsts.Members.IsSecureClientStripped, Order = 4, EmitDefaultValue = false)]
        public bool IsSecureClient { get; set; }

        [DataMember(Name = ApiConsts.Members.RecordIdStripped, EmitDefaultValue = true)]
        public long RecordId { get; set; }
    }
}
