using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Subject;

[DataContract(Name = ApiConsts.Contracts.Subject, Namespace = "")]
public class SubjectWithNameTagResource
{
    [DataMember(Name = ApiConsts.Members.Id)]
    public long Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Reference)]
    public string Reference { get; set; }

    [DataMember(Name = ApiConsts.Members.TagValue)]
    public string Tag { get; set; }
}