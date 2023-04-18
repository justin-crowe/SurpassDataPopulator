using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Comment
{
    [DataContract(Name = ApiConsts.Contracts.Comment, Namespace = "")]
    public class CommentResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public long Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Text, Order = 1)]
        public string Text { get; set; }

        [DataMember(Name = ApiConsts.Members.Private, Order = 2)]
        public bool Private { get; set; }

        [DataMember(Name = ApiConsts.Members.DateCreated, Order = 3)]
        public DateTime DateCreated { get; set; }

        [DataMember(Name = ApiConsts.Members.CreatedBy, Order = 4)]
        public UserResource CreatedBy { get; set; }
    }
}
