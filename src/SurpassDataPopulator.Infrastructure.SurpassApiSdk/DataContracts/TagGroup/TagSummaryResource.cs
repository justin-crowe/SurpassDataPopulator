using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagGroup
{
    [DataContract(Name = ApiConsts.Contracts.TagSummaryResource, Namespace = "")]
    public class TagSummaryResource
    {
        [DataMember(Name = ApiConsts.Members.CategoryName, Order = 0)]
        public string CategoryName { get; set; }

        [DataMember(Name = ApiConsts.Members.GroupName, Order = 1)]
        public string GroupName { get; set; }

        [DataMember(Name = ApiConsts.Members.CategoryId, Order = 2)]
        public long CategoryId { get; set; }

        [DataMember(Name = ApiConsts.Members.GroupId, Order = 3)]
        public long GroupId { get; set; }

        [DataMember(Name = ApiConsts.Members.TagTypeKey, Order = 4)]
        public short TagTypeKey { get; set; }
    }
}
