using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Candidate;

[DataContract(Name = ApiConsts.Contracts.TagValue, Namespace = "")]
public class CandidateTagValueResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
    public long Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Name, Order = 1)]
    public string Name { get; set; }
}