using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemTagValue
{
    public class SubjectTagGroupResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 0, EmitDefaultValue = false)]
        public long Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Name, Order = 1, EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Subject, Order = 2, EmitDefaultValue = false)]
        public ItemTagValueSubjectResource Subject { get; set; }
    }
}
