using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Subject;

[DataContract(Name = ApiConsts.Contracts.Subject, Namespace = "")]
public class SubjectUpdateResource
{
    [DataMember(Name = ApiConsts.Members.Reference)]
    public string Reference { get; set; }

    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.PrimaryCentre)]
    public Resource PrimaryCentre { get; set; }

    [DataMember(Name = ApiConsts.Members.Status)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SubjectStatus? Status { get; set; }

    [DataMember(Name = ApiConsts.Members.UseMasterList)]
    public bool UseMasterList { get; set; }

    [DataMember(Name = ApiConsts.Members.EnableCheckboxesInItemAuthoring)]
    public bool? EnableCheckboxesInItemAuthoring { get; set; }
}