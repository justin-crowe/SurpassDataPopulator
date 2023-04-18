using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details
{
    [DataContract(Name = ApiConsts.Contracts.Subject, Namespace = "")]
    public class ItemSubjectResource
    {
        [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
        public int? Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Reference, EmitDefaultValue = true)]
        public string Reference { get; set; }
    }
}
