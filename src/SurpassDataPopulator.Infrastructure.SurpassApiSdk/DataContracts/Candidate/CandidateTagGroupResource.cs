using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Candidate
{
    [DataContract(Name = ApiConsts.Contracts.TagGroup, Namespace = "")]
    public class CandidateTagGroupResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public long Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Name, Order = 1)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Values, Order = 2)]
        public IEnumerable<CandidateTagValueResource> Values { get; set; }
    }
}
